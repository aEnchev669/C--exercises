namespace MyApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int quantityOfFood = int.Parse(Console.ReadLine());

			int[] orders = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
			Queue<int> orderQueue = new Queue<int>(orders);

            Console.WriteLine(orders.Max());

            for (int i = 0; i < orders.Length; i++)
			{
				
				if (quantityOfFood >= orderQueue.Peek())
				{
					quantityOfFood -= orderQueue.Dequeue();
				}
				else
				{
					break;
				}
			}

            if (orderQueue.Count == 0)
			{
                Console.WriteLine("Orders complete");
            }
			else
			{
                Console.WriteLine($"Orders left: {String.Join(" ", orderQueue)}");
            }
		}
	}
}