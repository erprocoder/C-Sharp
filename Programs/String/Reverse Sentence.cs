using System;

namespace ProgrammingHub
{
    class ReverseSentence
    {
        public static void Main()
        {
            Console.Write("Enter sentence : ");
            string str = Console.ReadLine();

            string[] words = str.Split(' ');

            Console.WriteLine("\nReverse Sentence : ");
            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write(words[i] + " ");
            }

            Console.ReadLine();
        }
    }
}