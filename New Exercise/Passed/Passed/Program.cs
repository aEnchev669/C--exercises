﻿using System.Threading.Channels;

namespace Passed
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double input = double.Parse(Console.ReadLine());

			if (input >= 3)
			{
				Console.WriteLine("Passed!");
			}
		}
	}
}