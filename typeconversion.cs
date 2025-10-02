using System;
class Program{
    static void Main() {
        object obj1 = "123";
        object obj2 = "Hello";
        //Is operator
        if(obj1 is string){
            Console.WriteLine("obj1 is a string");
        }
        //using as
        string str1 = obj1 as string;
        string str2 = obj2 as string;
        Console.WriteLine(str1);
        Console.WriteLine(str2);
        //convert
        try{
            int num1 = Convert.ToInt32(str1);
            Console.WriteLine(num1);
            int num2 = Convert.ToInt32(str2);
            Console.WriteLine(num2);
        }
        catch(Exception e){
            Console.WriteLine($"Conversion failed: {e.Message}");

        }}}