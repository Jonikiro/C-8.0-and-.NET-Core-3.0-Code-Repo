using System;
using static System.Console;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i < 100) {
                if (i % 10 == 0) {
                    WriteLine();
                }
                i++;
                
                if ((i % 3 == 0) & (i % 5 == 0)){
                    Write("FizzBuzz");
                } else if (i % 3 == 0) {
                    Write("Fizz");
                } else if (i % 5 == 0) {
                    Write("Buzz");
                } else {
                    Write(i);
                }
                Write(", ");
            }
        }
    }
}
