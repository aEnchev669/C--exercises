namespace ConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{

			int wagonMacCapacity = 4;

			int countOfPeople = int.Parse(Console.ReadLine());
			int[] countOfWagons = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToArray();

			for (int l = 0; l < countOfWagons.Length; l++)
			{
				while (countOfPeople != 0)
				{
					if (countOfWagons[l] < 4)
					{
						countOfWagons[l]++;
						countOfPeople--;
					}
					else
					{
						break;
					}
				}
			}
			if (countOfPeople == 0)
			{
				Console.WriteLine("The lift has empty spots!");
				Console.WriteLine(string.Join(' ', countOfWagons));
			}
			else if (countOfPeople > 0)
			{
				Console.WriteLine($"There isn't enough space! {countOfPeople} people in a queue!");
				Console.WriteLine(string.Join(' ', countOfWagons));
			}
		}

	}
}