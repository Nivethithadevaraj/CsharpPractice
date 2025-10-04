using System;
using System.Collections.Generic;
using System.Linq;
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public int Salary { get; set; }
}
class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>{
            new Employee{ Id = 1, Name = "Alice", Department="HR", Salary = 40000 },
            new Employee{ Id = 2, Name = "Bob", Department="IT", Salary = 60000 },
            new Employee{ Id = 3, Name = "Charlie", Department="IT", Salary = 50000 },
            new Employee{ Id = 4, Name = "David", Department="Finance", Salary = 45000 }
        };
        var filtered = employees.Where(e => e.Salary > 45000);
        var grouped = employees.GroupBy(e => e.Department);
        var ordered = employees.OrderByDescending(e => e.Salary);
        var selected = employees.Select(e => e.Name);
        Console.WriteLine("Filtered (Salary > 45000):");
        foreach (var e in filtered) Console.WriteLine(e.Name);
        Console.WriteLine("Grouped by Department:");
        foreach (var g in grouped)
        {
            Console.WriteLine(g.Key);
            foreach (var e in g) Console.WriteLine("  " + e.Name);
        }
        Console.WriteLine("Ordered by Salary:");
        foreach (var e in ordered) Console.WriteLine(e.Name + " " + e.Salary);
        Console.WriteLine("Selected Names:");
        foreach (var name in selected) Console.WriteLine(name);
    }
}