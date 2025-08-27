using System;
using System.Linq;

//Linq Example with Lambda Syntax
namespace ProgrammingHub
{
    class LinqLambdaSyntax
    {
        static void Main(string[] args)
        {
            string[] words = { "welcome", "to", "the", "world", "of", "programming", "hub" };
            //get only 2 letter words
            var twoLetterWords = words.Where(w => w.Length == 2);
            //get all words starting with w
            var wordsWithW = words.Where(w => w.StartsWith("w"));

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