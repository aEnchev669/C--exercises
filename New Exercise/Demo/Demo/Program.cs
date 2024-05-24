namespace Demo
{
	public class Program
	{
		static void Main(string[] args)
		{
			int[] num = {5};
		
			Add(num, 15);

			Console.WriteLine(num[0]);
		}

		public static void Add(int[] currNum, int value)
		{
			currNum[0] += value;
		}
	}
} 