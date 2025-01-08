using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Problem_1___Counter_Strike
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int totalEnergy = int.Parse(Console.ReadLine());
			int wonBattles = 0;

			string command;
			while ((command = Console.ReadLine()) != "End of battle")
			{
				int distance = int.Parse(command);

				if (distance <= totalEnergy)
				{
					totalEnergy -= distance;
					wonBattles++;
				}
				else
				{
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {totalEnergy} energy");
					return;
                }

				if (wonBattles % 3 == 0)
				{
					totalEnergy += wonBattles;
				}
			}

            Console.WriteLine($"Won battles: {wonBattles}. Energy left: {totalEnergy}");
        }
	}
}