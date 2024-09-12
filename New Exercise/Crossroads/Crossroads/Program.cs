namespace Crossroads
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int durationOfGreenLight = int.Parse(Console.ReadLine());
			int durationOfFreeWindow = int.Parse(Console.ReadLine());

			int greenCounter = durationOfGreenLight;
			int carPassed = 0;

			string input = Console.ReadLine();
			while (input != "END")
			{
				if(input == "green")
				{
					greenCounter = durationOfGreenLight;
				}
				else if(greenCounter - input.Length >= 0)
				{
					greenCounter -= input.Length;
					carPassed++;
				}
				else
				{

				}

			}
		}
	}
}