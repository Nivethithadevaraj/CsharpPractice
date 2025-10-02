using System;
public class Student
{
    private string name;
    private int age;
    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Name cannot be empty");
            name = value;
        }

    }
    public int Age
    {
        get => age;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Invalide age");
            age = value;
        }
    }
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
    class Program
    {
        static void Main()
        {
           Student s1= new Student("Nivethitha", 21);
            Console.WriteLine($"Student: {s1.Name}, Age: {s1.Age}");
        }
    }