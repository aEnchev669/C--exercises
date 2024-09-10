using System.Linq;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

			int numbersCount = input[0];
			int numbersToPop = input[1];
			int numberToLookFor = input[2];

			int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

			Stack<int> stack = new Stack<int>();

			for (int i = 0; i < numbersCount; i++)
			{
				stack.Push(numbers[i]);
			}

			for (int p = 0; p < numbersToPop; p++)
			{
				if (stack.Count > 0)
				{
					stack.Pop();
				}
			}

			bool containsOrNot = stack.Contains(numberToLookFor);

			if (containsOrNot)
			{
				Console.WriteLine("true");
			}
			else
			{
				if (stack.Count > 0)
				{
					Console.WriteLine(stack.Min());
				}
				else
				{
					Console.WriteLine(0);
				}
			}
		}
	}
}