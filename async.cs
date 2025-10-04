using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Fetching data...");
        await Task.Delay(2000); 
        Console.WriteLine("Data fetched successfully");
    }
}
