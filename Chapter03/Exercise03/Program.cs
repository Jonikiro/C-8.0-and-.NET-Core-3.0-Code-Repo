using System;
using static System.Console;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Write("Enter a number between 0 and 255: ");
                int n = int.Parse(ReadLine());
                Write("Enter another number between 0 and 255: ");
                int m = int.Parse(ReadLine());
                WriteLine($"{n} divided by {m} is {n / m}");
            } catch(FormatException) {
                WriteLine("You need to enter a valid number.");
            } catch(DivideByZeroException) {
                WriteLine("You tried to divide by zero. Don't.");
            } catch(OverflowException) {
                WriteLine("One of the numbers you entered was too large or too small.");
            } catch(Exception ex) {  
                WriteLine($"{ex.GetType()}: {ex.Message}");
            }

            int x = 3 << 2;
            int y = 10 >> 1;
            int z = 10 & 8;
            int q = 10 | 7;

            WriteLine($"Expected: 12 - Actual: {x}");
            WriteLine($"Expected: 5  - Actual: {y}");
            WriteLine($"Expected: 8  - Actual: {z}");
            WriteLine($"Expected: 15 - Actual: {q}");

        }
    }
}
