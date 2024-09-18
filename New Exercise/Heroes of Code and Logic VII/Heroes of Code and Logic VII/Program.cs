using System.Security;

namespace Heroes_of_Code_and_Logic_VII
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int numberOfHeroes = int.Parse(Console.ReadLine());

			Dictionary<string, int> heroHp = new Dictionary<string, int>();
			Dictionary<string, int> heroMp = new Dictionary<string, int>();

			for (int i = 0; i < numberOfHeroes; i++)
			{
				var newHeroStats = Console.ReadLine().Split(' ').ToArray();

				string name = newHeroStats[0];
				int hp = int.Parse(newHeroStats[1]);
				int mp = int.Parse(newHeroStats[2]);

				heroHp[name] = hp;
				heroMp[name] = mp;
			}

			string inputCommand;
			while ((inputCommand = Console.ReadLine()) != "End")
			{
				string[] command = inputCommand.Split(" - ");
				string commandType = command[0];
				string heroName = command[1];

				if (commandType == "CastSpell")
				{
					int mpNeeded = int.Parse(command[2]);
					string spellName = command[3];

					int currentMp = heroMp[heroName];

					if (currentMp >= mpNeeded)
					{
						heroMp[heroName] -= mpNeeded;
						Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroMp[heroName]} MP!");     
					}
					else
					{
						Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
					}
				}
				else if (commandType == "TakeDamage")
				{
					int damage = int.Parse(command[2]);
					string attackersName = command[3];

					int currentHp = heroHp[heroName];

					if (currentHp > damage)
					{
						heroHp[heroName] -= damage;
						Console.WriteLine($"{heroName} was hit for {damage} HP by {attackersName} and now has {heroHp[heroName]} HP left!");   
					}
					else
					{
						heroMp.Remove(heroName);
						heroHp.Remove(heroName);
						Console.WriteLine($"{heroName} has been killed by {attackersName}!");
					}
				}
				else if (commandType == "Recharge")
				{
					int amount = int.Parse(command[2]);
					int currentMp = heroMp[heroName];

					if (currentMp + amount <= 200)
					{
						heroMp[heroName] += amount;
						Console.WriteLine($"{heroName} recharged for {amount} MP!");
					}
					else
					{
						int amountRecoverd = amount - (currentMp + amount - 200);
						heroMp[heroName] = 200;

						Console.WriteLine($"{heroName} recharged for {amountRecoverd} MP!");
					}
				}
				else if (commandType == "Heal")
				{
					int amount = int.Parse(command[2]);
					int currentHp = heroHp[heroName];

					if (currentHp + amount <= 100)
					{
						heroHp[heroName] += amount;
						Console.WriteLine($"{heroName} healed for {amount} HP!");
					}
					else
					{
						int amountRecoverd = amount - (currentHp + amount - 100);
						heroHp[heroName] = 100;

						Console.WriteLine($"{heroName} healed for {amountRecoverd} HP!");
					}
				}
			}

			foreach (var heroNHp in heroHp)
			{
				string hero = heroNHp.Key;
				int hp = heroNHp.Value;

				foreach (var heroNMp in heroMp)
				{
					if (heroNMp.Key == hero)
					{
						int mp = heroNMp.Value;
						Console.WriteLine($"{hero}\n  HP: {hp}\n  MP: {mp}");
					}
				}
			}
		}
	}
}
