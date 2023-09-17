using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            int sum = 0;
            int index = 0;

            for (int r = 0; r < size; r++)
            {
                int[] rowData = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                sum += rowData[index];
                index++;

                for (int c = 0; c < size; c++)
                {
                    matrix[r, c] = rowData[c];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
