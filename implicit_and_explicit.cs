using System;
class Program{
	static void Main(){
		int num1 = 100;
		double nume2 = num1; // implicit conversion
		Console.WriteLine($"int:{num1}");
		Console.WriteLine($"double:{nume2}");
		double num3 = 99.99;
		int num4 = (int)num3; // explicit conversion
		Console.WriteLine($"double:{num3}");
		Console.WriteLine($"int:{num4}");
	}}