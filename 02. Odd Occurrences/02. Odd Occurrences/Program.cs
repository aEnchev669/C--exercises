using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();

            Dictionary<string, int> map = new Dictionary<string, int>();

            foreach (var items in arr)
            {
                string item = items.ToLower();
                if (map.ContainsKey(item))
                {
                    map[item]++;
                }
                else
                {
                    map.Add(item, 1);
                }
            }



            foreach (var item in map)
            {
                if (item.Value % 2 == 1)
                {
                    Console.Write($"{item.Key} ");

                }
            }
        }
    }
}
