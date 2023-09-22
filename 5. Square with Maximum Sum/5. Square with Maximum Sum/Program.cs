using System;
using System.Linq;

namespace _5._Square_with_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();


            int[,] matrix = new int[size[0], size[1]];
            for (int r = 0; r < size[0]; r++)
            {
                int[] data = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                for (int c = 0; c < size[1]; c++)
                {
                    matrix[r, c] = data[c];
                }
            }

            int biggestSum = int.MinValue;
            int[] rowNCol = new int[2];

            for (int r = 0; r < size[0] - 1; r++)
            {
                for (int c = 0; c < size[1] - 1; c++)
                {

                    int sum = matrix[r, c] + matrix[r, c + 1] + matrix[r + 1, c] + matrix[r + 1, c + 1];
                    if (sum > biggestSum)
                    {
                        rowNCol[0] = r;
                        rowNCol[1] = c;
                        biggestSum = sum;
                    }
                }
            }


            Console.WriteLine(matrix[rowNCol[0], rowNCol[1]] + " " + matrix[rowNCol[0], rowNCol[1] + 1]);
            Console.WriteLine(matrix[rowNCol[0] + 1, rowNCol[1]] + " " + matrix[rowNCol[0] + 1, rowNCol[1] + 1]);

            Console.WriteLine(biggestSum);
        }
    }
}
