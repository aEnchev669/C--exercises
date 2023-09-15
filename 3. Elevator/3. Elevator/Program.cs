using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int people =  int.Parse(Console.ReadLine());
          int maxCapacity = int.Parse(Console.ReadLine());

            int courses = 0;


            

            while (people > 0)
            {
                people -= maxCapacity;
                courses++;
            }

            Console.WriteLine(courses);
        }
    }
}
