
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();


            int rows = sizes[0];
            int cols = sizes[1];

            int[,] matrix = new int[rows, cols];

            int sum = 0;
            for (int r = 0; r < rows; r++)
            {
                int[] rowdata = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                for (int c = 0; c < cols; c++)
                {
                    sum += rowdata[c];

                    matrix[r, c] = rowdata[c];
                }

            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);

        }
    }
}
