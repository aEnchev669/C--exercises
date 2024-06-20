
namespace ConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double food = double.Parse(Console.ReadLine()) * 1000;
			double hay = double.Parse(Console.ReadLine()) * 1000;
			double cover = double.Parse(Console.ReadLine()) * 1000;
			double pigsWeight = double.Parse(Console.ReadLine()) * 1000;

			for (int day = 1; day <= 30; day++)
			{


				food -= 300;

				if (day % 2 == 0)
				{
					hay -= 0.05 * food;
				}
				if (day % 3 == 0)
				{
					cover -= pigsWeight / 3;
				}
			}

			if (food <= 0 || hay <= 0 || cover <= 0)
			{
				Console.WriteLine("Merry must go to the pet store!");
			}
			else
			{
				Console.WriteLine($"Everything is fine! Puppy is happy! Food: {(food / 1000):f2}, Hay: {(hay / 1000):f2}, Cover: {(cover / 1000):f2}.");
			}

		}
	}
}