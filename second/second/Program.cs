﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            int sum = 0;

            sum = num1 + num2;
            sum = sum / num3;
            sum = sum * num4;
            Console.WriteLine(sum);
        }
    }
}
