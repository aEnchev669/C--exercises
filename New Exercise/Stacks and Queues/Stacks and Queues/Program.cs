namespace Stacks_and_Queues
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			Stack<int> stack = new Stack<int>();

			for (int i = 0; i < n; i++)
			{
				string[] query = Console.ReadLine().Split(" ").ToArray();

				int command = int.Parse(query[0]);

				if (command == 1)
				{
					int numberToAdd = int.Parse(query[1]);
					stack.Push(numberToAdd);
				}
				else if (command == 2)
				{
					if (stack.Count > 0)
					{
						stack.Pop();
					}
				}
				else if (command == 3)
				{
					if (stack.Count > 0)
					{
						Console.WriteLine(stack.Max());
					}
				}
				else if (command == 4)
				{
					if (stack.Count > 0)
					{
						Console.WriteLine(stack.Min());
					}
				}

			}

			Console.WriteLine(string.Join(", ", stack));
		}
	}
}