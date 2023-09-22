using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];

            for (int r = 0; r < rows; r++)
            {
                int[] data = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                matrix[r] = data;

                //for (int c = 0; c < data.Length; c++)
                //{
                //    matrix[r][c] = data[c];
                //}
            }

            string[] cmd = Console.ReadLine().Split(' ').ToArray();

            while (cmd[0] != "END")
            {
                int row = int.Parse(cmd[1]);
                int col = int.Parse(cmd[2]);
                int value = int.Parse(cmd[3]);

                if (row < 0 || col < 0 || matrix.Length <= row || matrix[row].Length <= col)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (cmd[0] == "Add")
                    {
                        matrix[row][col] += value;
                    }
                    else if (cmd[0] == "Subtract")
                    {
                        matrix[row][col] -= value;
                    }
                }
                cmd = Console.ReadLine().Split(' ').ToArray();

            }

            for (int r = 0; r < rows; r++)
            {
                Console.WriteLine(String.Join(" ", matrix[r]));
            }

            //Top or Bottom

            //for (int r = 0; r < rows; r++)
            //{
            //    for (int c = 0; c < matrix[r].Length; c++)
            //    {
            //        Console.Write(matrix[r][c] + " ");

            //    }

            //}
        }
    }
}
