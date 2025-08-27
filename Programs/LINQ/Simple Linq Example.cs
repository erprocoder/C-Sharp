using System;
using System.Linq;

//Simple Linq Example
namespace ProgrammingHub
{
    class SimplelinqExample
    {
        static void Main(string[] args)
        {
            string[] words = { "welcome", "to", "the", "world", "of", "programming", "hub" };
            //get only 2 letter words
            var twoLetterWords = from word in words
                             where word.Length == 2
                             select word;
            //get all words starting with w
            var wordsWithW = from word in words
                             where word.StartsWith("w")
                             select word;

            //Print each word out
            foreach (var word in twoLetterWords)
            {
                Console.WriteLine(word);
            }

            foreach (var word in wordsWithW)
            {
                Console.WriteLine(word);
            }

            Console.ReadLine();
        }

    }
}