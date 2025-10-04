using System;
using System.Threading;
using System.Threading.Tasks;

public sealed class Logger
{
    private static Logger instance = null;
    private static readonly object instanceLock = new object();

    private Logger()
    {
        Console.WriteLine("Logger instance created.");
    }

    public static Logger Instance
    {
        get
        {
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }
        }
    }

    public void Log(string message)
    {
        string logEntry = $"{DateTime.Now:HH:mm:ss.fff} [Thread {Thread.CurrentThread.ManagedThreadId}] {message}";
        Console.WriteLine(logEntry);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Starting Threads");

        Thread[] threads = new Thread[5];
        for (int i = 0; i < 5; i++)
        {
            threads[i] = new Thread(() =>
            {
                Logger.Instance.Log("Message from Thread");
            });
            threads[i].Start();
        }

        foreach (var t in threads)
            t.Join();

        Console.WriteLine("Starting Tasks");

        Task[] tasks = new Task[5];
        for (int i = 0; i < 5; i++)
        {
            tasks[i] = Task.Run(() =>
            {
                Logger.Instance.Log("Message from Task");
            });
        }

        Task.WaitAll(tasks);

        Console.WriteLine("Program Finished");
    }
}
