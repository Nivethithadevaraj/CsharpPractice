using System;
class Program{
    static void Main(){
        int nonNullable = 10;
        Console.WriteLine("Non-nullable int: " + nonNullable);
        int? nullable = null;
        Console.WriteLine("Nullable int (null): " + nullable);
        nullable = 20;
        Console.WriteLine("Nullable int (value): " + nullable);
    }}