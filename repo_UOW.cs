using System;
using System.Collections.Generic;
public class Employee{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class EmployeeRepository{
    private readonly List<Employee> _employees; 
    public EmployeeRepository(List<Employee> employees){
        _employees = employees;
    }
    public IEnumerable<Employee> GetAll(){
        return _employees;
    }
    public void Add(Employee emp){
        _employees.Add(emp);
    }
}

public class UnitOfWork{
    private readonly List<Employee> _dbContext = new List<Employee>(); // Simulated DB
    public EmployeeRepository Employees { get; }
    public UnitOfWork(){
        Employees = new EmployeeRepository(_dbContext);
    }
    public void Save(){
        Console.WriteLine("Changes saved to DB.");
    }
}

class Program{
    static void Main(){
        var uow = new UnitOfWork();
        uow.Employees.Add(new Employee { Id = 1, Name = "Nivi" });
        uow.Employees.Add(new Employee { Id = 2, Name = "Arun" });
        uow.Save();
        Console.WriteLine("\nEmployee List");
        foreach (var emp in uow.Employees.GetAll())
        {
            Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}");
        }}}