namespace Gaming_Store
{
	internal class Program
	{
		static void Main(string[] args)
		{
			decimal budget = decimal.Parse(Console.ReadLine());

			decimal totalSpend = 0;

			string gameName;
			while ((gameName = Console.ReadLine()) != "Game Time")
			{
				decimal price = 0;

				if (gameName == "OutFall 4")
				{
					price = 39.99M;
				}
				else if (gameName == "CS: OG")
				{
					price = 15.99M;
				}
				else if (gameName == "Zplinter Zell")
				{
					price = 19.99M;
				}
				else if (gameName == "Honored 2")
				{
					price = 59.99M;
				}
				else if (gameName == "RoverWatch")
				{
					price = 29.99M;
				}
				else if (gameName == "RoverWatch Origins Edition")
				{
					price = 39.99M;
				}
				else
				{
					Console.WriteLine("Not Found");
					continue;
				}


				if (budget < price)
				{
					Console.WriteLine("Too Expensive");
				}
				else
				{
					budget -= price;
					totalSpend += price;
					Console.WriteLine($"Bought {gameName}");
				}

				if (budget <= 0)
				{
					Console.WriteLine("Out of money!");
					return;
				}
			}

			Console.WriteLine($"Total spent: ${totalSpend:f2}. Remaining: ${budget:f2}");
		}
	}
}