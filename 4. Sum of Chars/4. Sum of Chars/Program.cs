using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                char charInt = char.Parse(Console.ReadLine());
                sum += charInt;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
