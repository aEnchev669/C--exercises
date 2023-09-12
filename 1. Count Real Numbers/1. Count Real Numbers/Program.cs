using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, int> integers = new SortedDictionary<int, int>();

            string[] arr = Console.ReadLine().Split(' ').ToArray();

            foreach (var item in arr)
            {
                int number = int.Parse(item);
                if (integers.ContainsKey(number))
                {
                    integers[number]++;
                }
                else
                {
                    integers.Add(number, 1);
                }
            }

            foreach (var integer in integers)
            {
                Console.WriteLine($"{integer.Key} -> {integer.Value}");
            }
        }
    }
}
