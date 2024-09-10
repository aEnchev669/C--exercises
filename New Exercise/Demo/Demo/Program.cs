namespace Demo
{
	public class Program
	{
		static void Main(string[] args)
		{
			int[] num = {5};

			

			Console.WriteLine(Add(num[0], 15));
		}

		public static int Add(int currNum, int value)
		{
			return currNum += value;
		}
	}
} 