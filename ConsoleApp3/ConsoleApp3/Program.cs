using System;
using System.Linq;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsNCols = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();


            int rows = rowsNCols[0];
            int cols = rowsNCols[1];

            int[,] matrix = new int[rows, cols];
            for (int r = 0; r < rows; r++)
            {
                int[] rowData = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = rowData[c];
                }
            }


            for (int c = 0; c < cols; c++)
            {
                int sum = 0;
                for (int r = 0; r < rows; r++)
                {
                    sum+= matrix[r, c];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
