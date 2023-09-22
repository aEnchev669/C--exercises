using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8.Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double> map = new Dictionary<string, double>();
            double min = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = 3.14 * radius * radius * height;

                if (min < volume)
                {
                    min = volume;
                }

                map.Add(model, volume);

            }

         
            Console.WriteLine(map.FirstOrDefault(m => m.Value == min).Key);


        }
    }
}
