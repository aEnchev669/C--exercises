namespace Songs_Queue
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(", ").ToArray();


			Queue<string> songs = new Queue<string>();

			input.ToList().ForEach(x => songs.Enqueue(x));



			while (songs.Count != 0)
			{
				string[] command = Console.ReadLine().Split().ToArray();

				if (command[0] == "Play")
				{
					songs.Dequeue();
				}
				else if (command[0] == "Add")
				{
					string song = string.Join(" ", command.Skip(1));

					if (!(songs.Any(s => s == song)))
					{ 
						songs.Enqueue(song);
					}
					else
					{
						Console.WriteLine($"{song} is already contained!");
					}
				}
				else if (command[0] == "Show")
				{
                    Console.WriteLine(string.Join(", ", songs));
                }
			}
			Console.WriteLine("No more songs!");
		}
	}
}