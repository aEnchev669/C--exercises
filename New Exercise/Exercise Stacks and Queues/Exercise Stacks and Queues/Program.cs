namespace Exercise_Stacks_and_Queues
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// First Exercise
			var NSX = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			Stack<int> stack = new Stack<int>();

			for (int i = 0; i < NSX[0]; i++)
			{
				stack.Push(numbers[i]);
			}

			for (int i = 0; i < NSX[1]; i++)
			{
				stack.Pop();
			}

			if (stack.Count == 0)
			{
                Console.WriteLine(0);
				return;
            }

			int currNumber = stack.FirstOrDefault(s => s == NSX[2]);
			if (currNumber != 0)
			{
                Console.WriteLine("true");
            }
			else
			{
				Console.WriteLine(stack.Min());
			}




			


		}
	}
}