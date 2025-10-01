using System;

class Program
{
	static void Main()
	{
#if DEBUG
        Console.WriteLine("Debug build: Detailed logs enabled");
        Console.WriteLine("Connecting to TEST database...");
#else
		Console.WriteLine("Release build: Optimized version");
		Console.WriteLine("Connecting to PRODUCTION database...");
#endif
	}
}
