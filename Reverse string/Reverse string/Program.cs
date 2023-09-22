using System;
using System.Collections;
using System.Collections.Generic;

namespace Reverse_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            foreach (var word in words)
            {
                stack.Push(word);
            }

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }
            
        }
    }
}
