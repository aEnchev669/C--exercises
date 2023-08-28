using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.SUm_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                sum+= int.Parse((number[i]).ToString());

                
            }

            Console.WriteLine(sum);
        }
    }
}



