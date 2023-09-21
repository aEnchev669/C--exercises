using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            for (int r = 0; r < size; r++)
            {
                string data = Console.ReadLine();

                for (int c = 0; c < size; c++)
                {
                    matrix[r, c] = data[c];
                }
            }

            char givenElement = char.Parse(Console.ReadLine());


            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    if (matrix[r, c] == givenElement)
                    {
                        Console.WriteLine($"({r}, {c})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{givenElement} does not occur in the matrix");



        }
    }
}
