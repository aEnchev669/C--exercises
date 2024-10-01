namespace Fashion_Boutique
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
			int maxCapacity= int.Parse(Console.ReadLine());

			Stack<int> stack = new Stack<int>();

			input.ToList().ForEach(x => stack.Push(x));

			int sum = 0;
			int countOfRacks = 1;
			while (stack.Count != 0)
			{
				if(sum + stack.Peek()  <= maxCapacity)
				{
					sum += stack.Pop();
				}
				else
				{
					countOfRacks++;
					sum = 0;
				}
			}
            Console.WriteLine(countOfRacks);
        }
	}
}