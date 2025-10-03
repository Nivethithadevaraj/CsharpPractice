using System;
class Person { 
   public string Name;
}
class Program{
    static void Main() { }
        Person p1 = new Person();
        p1.Name = "Nivi";
        Person p2 = p1;
        p2.Name = "Nivethitha";
        Console.WriteLine(p1.Name);
    }}