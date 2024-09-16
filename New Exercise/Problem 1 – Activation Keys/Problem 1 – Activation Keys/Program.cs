using System.Data.SqlTypes;

namespace Problem_1___Activation_Keys
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string key = Console.ReadLine();

			string input;
			while ((input = Console.ReadLine()) != "Generate")
			{
				string[] command = input.Split(">>>").ToArray();

				if (command[0] == "Contains")
				{
					string substring = command[1];
					bool containsOrNot = key.Contains(substring);
					if (containsOrNot)
					{
						Console.WriteLine($"{key} contains {substring}");
					}
					else
					{
						Console.WriteLine("Substring not found!");
					}
				}
				else if (command[0] == "Flip")
				{
					string upperOrLower = command[1];
					int stardIdnex = int.Parse(command[2]);
					int endIdnex = int.Parse(command[3]);

					string letters = key.Substring(stardIdnex, endIdnex - stardIdnex);
					key = key.Remove(stardIdnex, endIdnex - stardIdnex);

					if (upperOrLower == "Upper")
					{
						key = key.Insert(stardIdnex, letters.ToUpper());
					}
					else if (upperOrLower == "Lower")
					{
						key = key.Insert(stardIdnex, letters.ToLower());
					}

					Console.WriteLine(key);
				}
				else if (command[0] == "Slice")
				{
					int stardIdnex = int.Parse(command[1]);
					int endIdnex = int.Parse(command[2]);

					key = key.Remove(stardIdnex, endIdnex - stardIdnex);
                    Console.WriteLine(key);
                }
			}

            Console.WriteLine($"Your activation key is: {key}");
        }
	}
}