using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int maxCapcity = 255;
            int water = 0;

            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                int givenLiters = int.Parse(Console.ReadLine());


                if((water + givenLiters) <= maxCapcity)
                {
                    water += givenLiters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }


            }
            Console.WriteLine(water);
        }
    }
}
