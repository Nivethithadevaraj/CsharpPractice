using System;
using System.Collections.Generic;
public class Student : IComparable<Student>{
    public string Name { get; set; }
    public int Age { get; set; }
    public int CompareTo(Student other){
        if (other == null) return 1;
        return this.Age.CompareTo(other.Age);
    }
    public override string ToString(){
        return $"{Name} ({Age} years)";
    }}
class Program{
    static void Main(){
        List<Student> students = new List<Student>{
            new Student { Name = "Nivi", Age = 22 },
            new Student { Name = "Arun", Age = 25 },
            new Student { Name = "Meena", Age = 20 }
        };
        Console.WriteLine("Before Sorting:");
        foreach (var s in students)
            Console.WriteLine(s);
        students.Sort();
        Console.WriteLine("\nAfter Sorting by Age:");
        foreach (var s in students)
            Console.WriteLine(s);
    }}