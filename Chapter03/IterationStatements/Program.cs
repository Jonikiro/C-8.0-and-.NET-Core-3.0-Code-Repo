using System;
using static System.Console;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x < 10) {
                WriteLine(x);
                x++;
            }

            string password = string.Empty;
            int counter = 0;
            do {
                Write("Enter your password: ");
                password = ReadLine();
                if (counter++ >= 9) {
                    break;
                }
            } while (password != "Pa$$w0rd");

            if (counter >= 9){
                WriteLine("I'm sorry, but you've exceeded your alloted attempts");
            } else {
                WriteLine("Correct!");
            }

            for (int y = 1; y <= 10; y++) {
                WriteLine(y);
            }

            string[] names = {"Adam","Barry","Charlie"};
            foreach (string name in names) {
                WriteLine($"{name} has {name.Length} characters.");
            }
        }
    }
}
