using System;
using static System.Console;

namespace BooleanOperators
{
    class Program
    {
        static void Main(string[] args) {
            bool a = true;
            bool b = false;
            WriteLine($"a is {a}, b is {b}.");
            WriteLine();

            WriteLine($"{"AND",-3} | {"a",-5} | {"b",-5} ");
            WriteLine($"{"a",-3} | {a & a,-5} | {a & b,-5} ");
            WriteLine($"{"b",-3} | {b & a,-5} | {b & b,-5} ");
            WriteLine();

            WriteLine($"{"OR",-3} | {"a",-5} | {"b",-5} ");
            WriteLine($"{"a",-3} | {a | a,-5} | {a | b,-5} ");
            WriteLine($"{"b",-3} | {b | a,-5} | {b | b,-5} ");
            WriteLine();

            WriteLine($"{"XOR",-3} | {"a",-5} | {"b",-5} ");
            WriteLine($"{"a",-3} | {a ^ a,-5} | {a ^ b,-5} ");
            WriteLine($"{"b",-3} | {b ^ a,-5} | {b ^ b,-5} ");
            WriteLine();

            WriteLine($"a & DoStuff() = {a && DoStuff()}\n");
            WriteLine($"b & DoStuff() = {b && DoStuff()}\n");
        }

        private static bool DoStuff() {
            WriteLine("I am doing some stuff.");
            return true;
        }
    }
}
