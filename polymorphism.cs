using System;
class Calculator{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public double Add(double a, double b)
    {
        return a + b;
    }}
class Animal{
    public virtual void Speak(){
        Console.WriteLine("Animal speaks");
    }}
class Dog:Animal{
    public override void Speak(){
        Console.WriteLine("Dog barks");
    }}
class Program{
    static void Main(){
        Calculator calc=new Calculator();
        Console.WriteLine($"Integer Add: {calc.Add(5,10)}");
        Console.WriteLine($"Double Add: {calc.Add(5.5,10.2)}");
        Animal myAnimal=new Animal();
        Animal myDog=new Dog();
        myAnimal.Speak();
        myDog.Speak();
    }}