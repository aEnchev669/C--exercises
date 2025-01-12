namespace Key_Revolver
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int priceOfBullet = int.Parse(Console.ReadLine());
			int sizeOfGunBarrel = int.Parse(Console.ReadLine());
			var bullets = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var locks = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int valueOfIntelligence = int.Parse(Console.ReadLine());


			Stack<int> stackOfBullets = new Stack<int>(bullets);
			Queue<int> queueOfLocks = new Queue<int>(locks);
			bool getThrough = false;

			for (int i = 0; i < bullets.Length; i++)
			{
				if (i % sizeOfGunBarrel == 0 && i != 0)
				{
					Console.WriteLine("Reloading!");
				}
				if (queueOfLocks.Count == 0)
				{
					getThrough = true;
					break;
				}
				int bullet = stackOfBullets.Pop();

				int lockk = queueOfLocks.Peek();
				if (bullet <= lockk)
				{
					queueOfLocks.Dequeue();
					Console.WriteLine("Bang!");
				}
				else
				{
					Console.WriteLine("Ping!");
				}
			}

			if (queueOfLocks.Count == 0)
			{
				getThrough = true;
			}
			if (getThrough)
			{
				int totalBulletsCost = (bullets.Length - stackOfBullets.Count) * priceOfBullet;
				Console.WriteLine($"{stackOfBullets.Count} bullets left. Earned ${valueOfIntelligence - totalBulletsCost}");
			}
			else
			{
                Console.WriteLine($"Couldn't get through. Locks left: {queueOfLocks.Count}");
            }
		}
	}
}