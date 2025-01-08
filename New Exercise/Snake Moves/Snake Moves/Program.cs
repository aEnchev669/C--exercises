namespace Snake_Moves
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] mAndN = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			string snake = Console.ReadLine();
			Queue<char> queue = new Queue<char>();

			foreach (var letter in snake)
			{
				queue.Enqueue(letter);
			}

			for (int row = 0; row < mAndN[0]; row++)
			{
				string[] word = new string[mAndN[1]];
				for (int col = 0; col < mAndN[1]; col++)
				{
					char letter = queue.Dequeue();
					word[col] = letter.ToString();
					queue.Enqueue(letter);
				}
				if (row % 2 != 0)
				{
					Array.Reverse(word);

				}
				Console.WriteLine(string.Join("", word));
			}

		}
	}
}