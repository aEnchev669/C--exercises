using System;

namespace _2._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            word = word.ToLower();
            int sum = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'y' || word[i] == 'o' || word[i] == 'u' || word[i] == 'e' || word[i] == 'i')
                {
                    sum++;
                }
           
            }
            Console.WriteLine(sum);
        }
    }
}

//.Split().ToString()
