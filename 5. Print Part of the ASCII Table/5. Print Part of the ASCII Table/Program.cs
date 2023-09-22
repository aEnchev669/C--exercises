using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.Print_Part_of_the_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            string chars = "";
            for (int i = n1; i <= n2; i++)
            {
                chars += (char)i + " ";
            }
            Console.WriteLine(chars);
        }
    }
}
