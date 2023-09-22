using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split(' ')
                .Where(w => w.Length % 2 == 0)
                .ToArray();

            Console.WriteLine(string.Join("\n", arr));

        }
    }
}
