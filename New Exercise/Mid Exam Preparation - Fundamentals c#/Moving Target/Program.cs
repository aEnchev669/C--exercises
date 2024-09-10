namespace ConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{

			List<int> targets = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();

			string[] command = Console.ReadLine()
				.Split(' ', StringSplitOptions.RemoveEmptyEntries)
				.ToArray();

			while (command[0] != "End")
			{
				if (command[0] == "Shoot")
				{
					int index = int.Parse(command[1]);
					int power = int.Parse(command[2]);

					if (index < targets.Count && index >= 0)
					{
						targets[index] -= power;

						if (targets[index] <= 0)
						{
							targets.RemoveAt(index);
						}
					}

				}
				else if (command[0] == "Add")
				{
					int index = int.Parse(command[1]);
					int value = int.Parse(command[2]);

					if (index < targets.Count && index >= 0)
					{
						targets.Insert(index, value);
					}
					else
					{
						Console.WriteLine("Invalid placement!");
					}
				}
				else if (command[0] == "Strike")
				{
					int index = int.Parse(command[1]);
					int radius = int.Parse(command[2]);

					if (index - radius >= 0 && index + radius < targets.Count)
					{
						targets.RemoveRange(index - radius, radius * 2 + 1);
					}
					else
					{
						Console.WriteLine("Strike missed!");
					}
				}

				command = Console.ReadLine()
					.Split(' ', StringSplitOptions.RemoveEmptyEntries)
					.ToArray();
			}

			Console.WriteLine(string.Join('|', targets));
		}

	}
}