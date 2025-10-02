using System;
public class Student{
    public const string SchoolName = "ABC Public School";
    public readonly int RollNumber;
    public string Name { get; set; }
    // Constructor
    public Student(string name, int roll){
        Name = name;
        RollNumber = roll; 
    }
    public void Display(){
        Console.WriteLine($"Name: {Name}, Roll: {RollNumber}, School: {SchoolName}");
    }}
class Program{
    static void Main(){
        Student s1 = new Student("Nivi", 101);
        s1.Display();

        Student s2 = new Student("Priya", 102);
        s2.Display();
    }}
