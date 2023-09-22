using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9.Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int totalSPices = 0;
            int days = 0;

            if (startingYield >= 100)
            {

                while (startingYield >= 100)
                {
                    totalSPices += startingYield;
                    totalSPices -= 26;
                    days++;

                    startingYield -= 10;
                }

                totalSPices -= 26;
            }

            Console.WriteLine(days);
            Console.WriteLine(totalSPices);
        }
    }
}
