namespace SortNumbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());
			int num3 = int.Parse(Console.ReadLine());

			List<int> list = new List<int>();
			list.Add(num1);
			list.Add(num2);
			list.Add(num3);

			
			Console.WriteLine(string.Join("\n", list.OrderByDescending(l => l)));
		}
	}
}