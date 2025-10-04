using System;
using System.Threading;
class AlarmClock
{

    public event Action OnRing;
    public void Start()
    {
        Console.WriteLine("Alarm set...waiting 3 seconds");
        Thread.Sleep(3000);

        OnRing?.Invoke();
    }
}
class Program
{
    static void Main()
    {
        AlarmClock alarm = new AlarmClock();

        alarm.OnRing += () => Console.WriteLine("Wake up! Alarm is ringing ");
        alarm.Start();
    }
}
