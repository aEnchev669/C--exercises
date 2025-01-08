namespace Shoot_for_the_Win
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] shotTargets = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			int countOfShotTargets = 0;
			string command;
			while((command = Console.ReadLine()) != "End")
			{
				int currTargetValue = 0;
				int indexToShootOn = int.Parse(command);

				if(indexToShootOn >= shotTargets.Length || indexToShootOn < 0)
				{
					continue;
				}

				currTargetValue = shotTargets[indexToShootOn];
				shotTargets[indexToShootOn] = -1;

				for(int i = 0; i < shotTargets.Length; i++)
				{
					if (shotTargets[i] == -1)
					{
						continue;
					}

					int currValue = shotTargets[i];

					if(currValue <= currTargetValue)
					{
						shotTargets[i] = currValue + currTargetValue;
					}
					else
					{
						shotTargets[i]-= currTargetValue;
					}
				}

				countOfShotTargets++;
			}

            Console.WriteLine($"Shot targets: {countOfShotTargets} -> {string.Join(' ', shotTargets)}");
        }
	}
}