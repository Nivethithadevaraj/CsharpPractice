using System;
public sealed class Singleton{
    private static readonly Singleton instance = new Singleton();
    private Singleton() { 
        Console.WriteLine("Singleton Instance Created!");
    }
    public static Singleton Instance{
        get{
            return instance;
        }}
    public void ShowMessage(){
        Console.WriteLine("Hello from Singleton!");
    }}
class Program{
    static void Main(){
        Console.WriteLine("Program started...");
        Singleton s1 = Singleton.Instance;
        Singleton s2 = Singleton.Instance;
        s1.ShowMessage();
        Console.WriteLine(s1 == s2 ? "Same instance" : "Different instances");
    }}