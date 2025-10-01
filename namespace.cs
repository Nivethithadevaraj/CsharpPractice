using System;
using System.Collections; 

namespace MySchool 
{
    class Student   
    {
        public string Name;

    }
}

class Program
{
    static void Main()
    {
        MySchool.Student s = new MySchool.Student(); 
        s.Name = "Nivi";                           
        Console.WriteLine(s.Name);
    }
}
