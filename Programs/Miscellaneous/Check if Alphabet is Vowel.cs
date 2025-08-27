using System;

namespace ProgrammingHub
{
    class Program
    {
        public static void Main()
        {
            char alphabet;
            char c;

            Console.Write("Enter a Alphabet : ");
            alphabet = Convert.ToChar(Console.ReadLine());

            c = Char.ToUpper(alphabet);

            if (c.Equals('A') || c.Equals('E') || c.Equals('I') || c.Equals('O') ||
                c.Equals('U'))
            {
                Console.WriteLine("{0} is vowel", alphabet);
            }
            else
            {
                Console.WriteLine("{0} is not vowel", alphabet);
            }

            //This line is to hold the output screen
            Console.Read();
        }
    }
}