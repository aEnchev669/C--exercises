namespace Balanced_Parentheses2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();

			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("NO");
				return;
			}

			Stack<char> stack = new Stack<char>();
			Queue<char> queue = new Queue<char>();

			for (int i = 0; i < input.Length; i++)
			{
				if (i < (input.Length) / 2)
				{
					stack.Push(input[i]);
				}
				else
				{
					queue.Enqueue(input[i]);
				}
			}


			for (int i = 0; i < input.Length / 2; i++)
			{
				char s = stack.Pop();
				char q = queue.Dequeue();
				if (s == '{' && q == '}')
				{
					continue;
				}
				else if (s == '[' && q == ']')
				{
					continue;
				}
				else if (s == '(' && q == ')')
				{
					continue;
				}

				Console.WriteLine("NO");
				return;
			}

			Console.WriteLine("YES");
		}
	}
}