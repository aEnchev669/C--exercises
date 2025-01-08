using System.Data;

namespace Moving_Target
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var targets = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

			bool isEnd = false;

			while (isEnd != true)
			{
				var input = Console.ReadLine().Split(' ').ToArray();

				string command = input[0];

				if (command == "End")
				{
					isEnd = true; 
					continue;
				}

				int index = int.Parse(input[1]);
				int power = int.Parse(input[2]);
				
				if (command == "Shoot")
				{
					if (index >= targets.Count || index < 0)
					{
						continue; 
					}

					targets[index] -= power;
					if (targets[index] <= 0)
					{
						targets.RemoveAt(index);
					}
				}
				else if (command == "Add")
				{
					if (index >= targets.Count || index < 0)
					{
						Console.WriteLine("Invalid placement!");
						continue;
					}
					
					targets.Insert(index,power);
					
				}
				else if (command == "Strike")
				{
					if ((index + power) >= targets.Count || (index - power) < 0)
					{
						Console.WriteLine("Strike missed!");
						continue;
					}
					else
					{
						int count = (power * 2) + 1;
						targets.RemoveRange(index - power, count);
					}
				}
			}

			Console.WriteLine(string.Join('|', targets));
		}
	}
}