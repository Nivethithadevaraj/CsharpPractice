using System;
delegate int MathOperation(int a, int b);
class Program
{
	static int Add(int x, int y) => x + y;
	static int Sub(int x, int y) => x - y;
	static int Mul(int x, int y) => x * y;
	static void Main()
	{
		MathOperation op;
		op = Add;
		Console.WriteLine("Addition: " + op(10, 5));
		op = Sub;
		Console.WriteLine("Subtraction: " + op(10, 5));
		op = Mul;
		Console.WriteLine("Multiplication: " + op(10, 5));
	}
}
