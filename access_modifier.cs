using System;
public class Student{
    public string Name = "Nivi";
    private int age = 21;
    protected string Grade = "A";
    internal string School = "ABC";
public int GetAge() { return age; }}
public class CollegeStudent : Student{
    public string GetGrade() { return Grade; }
}
class Program{
    static void Main(){
        Student s = new Student();
        Console.WriteLine(s.Name);
        Console.WriteLine(s.School);
        Console.WriteLine(s.GetAge());

        CollegeStudent cs = new CollegeStudent();
        Console.WriteLine(cs.GetGrade());
    }}