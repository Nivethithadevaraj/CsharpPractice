using System;
using System.Threading;
using System.Threading.Tasks;
class Program
{
    static void DoWork(string name)
    {
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"{name} iteration {i} on Thread {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(500);
        }
    }
    static void Main()
    {
        Console.WriteLine("Using Threads");
        Thread t1 = new Thread(() => DoWork("Thread 1"));
        Thread t2 = new Thread(() => DoWork("Thread 2"));
        t1.Start();
        t2.Start();
        t1.Join();
        t2.Join();
        Console.WriteLine("Using TPL (Tasks)");
        Task task1 = Task.Run(() => DoWork("Task 1"));
        Task task2 = Task.Run(() => DoWork("Task 2"));
        Task.WaitAll(task1, task2);
        Console.WriteLine("\nProgram Finished");
    }}