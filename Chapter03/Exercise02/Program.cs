using System;
using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 500;
            if (!(max > byte.MaxValue)) {
                for (byte i = 0; i < max; i++) {
                    WriteLine(i);
                }
            } else {
                WriteLine("max is too large for this loop.");
            }
        }
    }
}
