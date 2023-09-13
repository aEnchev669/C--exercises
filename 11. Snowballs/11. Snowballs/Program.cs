using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {

                double value = 0;
                int bestSnowballSnow = 0;
                int bestSnowballTime = 0;
                int bestSnowballQuality = 0;
                for (int i = 0; i < n; i++)
                {
                    int snowballSnow = int.Parse(Console.ReadLine());
                    int snowballTime = int.Parse(Console.ReadLine());
                    int snowballQuality = int.Parse(Console.ReadLine());


                    int sum = 1;

                    int snowPlusTIme = (snowballSnow / snowballTime);

                    int num = snowPlusTIme;
                    for (int j = 0; j < snowballQuality; j++)
                    {
                        sum *= num;
                    }
                    if (sum > value)
                    {
                        value = sum;

                        bestSnowballQuality = snowballQuality;
                        bestSnowballSnow = snowballSnow;
                        bestSnowballTime = snowballTime;
                    }

                }

                Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {value} ({bestSnowballQuality})");
            }
        }
    }
}
