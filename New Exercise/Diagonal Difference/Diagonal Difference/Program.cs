using System.Runtime.InteropServices;

namespace Diagonal_Difference
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int[,] matrix = new int[n, n];

			for (int row = 0; row < n; row++)
			{
				int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
				for (int col = 0; col < n; col++)
				{
					matrix[row, col] = array[col];
				}
			}

			int backward = n - 1;
			int primary = 0;
			int secondary = 0;
			int i = 0;
			for (int row = 0; row < n; row++)
			{

				primary += matrix[row, i];
				secondary += matrix[row, backward - i];
				i++;

			}

			if (primary > secondary)
			{
				Console.WriteLine(primary - secondary);
			}
			else
			{
				Console.WriteLine(secondary - primary);

			}
		}
	}
}