using System;
class InvalidAgeException : Exception{
    public InvalidAgeException(string message) : base(message) { }
}
class Program{
    static void Main(){
        try
        {
            int age = -5;
            if (age < 0)
                throw new InvalidAgeException("Age cannot be negative");
            Console.WriteLine("Age is valid: " + age);
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine("Custom Exception Caught: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Finally block executed");
        }
    }}