using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names;
            names = new string[4];
            int[] numbers = new int[4];

            for (int i = 0; i < 4; i++) {
                names[i] = Console.ReadLine();
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(string s in names) {
                Console.WriteLine(s);
            }
            foreach(int x in numbers) {
                Console.WriteLine(x);
            }
        }
    }
}
