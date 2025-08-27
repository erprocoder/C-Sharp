using System;

namespace ProgrammingHub
{
    class AutomorphicNumber
    {
        public static void Main()
        {
            Console.Write("Enter a number : ");
            int input = Convert.ToInt32(Console.ReadLine());

            int square = input * input;

            String inputAsString = input + "";
            String squareAsString = square + "";

            if (squareAsString.EndsWith(inputAsString))
            {
                Console.WriteLine("\n"+input + " is an Automorphic Number");
            }
            else
            {
                Console.WriteLine("\n"+input + " is not an Automorphic Number");
            }
            Console.ReadKey();
        }
    }
}