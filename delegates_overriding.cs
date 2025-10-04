using System;
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}
delegate void SpeakDelegate();
class Program
{
    static void Main()
    {
        Animal a = new Animal();
        Dog d = new Dog();
        SpeakDelegate del;
        del = a.Speak;
        del();
        del = d.Speak;
        del();
        Animal ad = new Dog();
        del = ad.Speak;
        del();
    }
}