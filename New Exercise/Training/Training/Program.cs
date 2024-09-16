namespace Training
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string key = "asdfghjkl";



			string letters = key.Substring(2, 5);
            Console.WriteLine(letters);
			
			key = key.Remove(2, 5);
			Console.WriteLine(key);

			key = key.Insert(2, letters.ToUpper());
			Console.WriteLine(key);

		}
	}
}