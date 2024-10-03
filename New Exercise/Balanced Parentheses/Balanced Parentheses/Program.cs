namespace Balanced_Parentheses
{
	internal class Program
	{
		static void Main(string[] args)
		{


			string input = Console.ReadLine();
			char[] firstHalf = input.Take(input.Length / 2).ToArray();
			char[] secondHalf = input.TakeLast(input.Length / 2).Reverse().ToArray();

			
			bool itsBalanced = true;
		

			for (int i = 0; i < firstHalf.Length; i++)
			{
				if (firstHalf[i] == '(')
				{
					if (secondHalf[i] != ')')
					{
						itsBalanced = false;
					}
				}
				else if (firstHalf[i] == '{')
				{
					if (secondHalf[i] != '}')
					{
						itsBalanced = false;
					}
				}
				else if (firstHalf[i] == '[')
				{
					if (secondHalf[i] != ']')
					{
						itsBalanced = false;
					}
				}


			}
			if (input.Length == 0 || input.Length > 1000)
			{
				itsBalanced=false;	
			}

			if (!itsBalanced)
			{
				Console.WriteLine("NO");
			}
			else
			{
				Console.WriteLine("YES");
			}
		}
	}
}