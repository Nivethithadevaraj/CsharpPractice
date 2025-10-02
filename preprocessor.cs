#define DEBUG
#define FEATURE_X

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Program started.");

#if DEBUG
        Console.WriteLine("Debug mode: Extra logging enabled.");
#else
        Console.WriteLine("Release mode: Running fast and optimized.");
#endif

#if FEATURE_X
        Console.WriteLine("Feature X is enabled.");
#elif FEATURE_Y
        Console.WriteLine("Feature Y is enabled.");
#else
        Console.WriteLine("No features enabled.");
#endif

        #region ExtraCheck
        int num = 10;
#if DEBUG
        if (num > 5)
        {
            Console.WriteLine("DEBUG check: num is greater than 5");
        }
#endif
        #endregion

#warning This is just a warning for demonstration.
#error Uncomment this line to stop compilation with an error!

        Console.WriteLine("Program finished.");
    }
}
