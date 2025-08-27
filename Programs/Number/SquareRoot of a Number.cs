using System;

namespace ProgrammingHub
{
    class SquareRoot
    {
        public static void Main()
        {
            int n;

            Console.Write("Enter Number : ");
            n = Convert.ToInt32(Console.ReadLine());

            double sq = Math.Sqrt(n);
            Console.Write("\nSquare root of " + n + " is " + Convert.ToString(Math.Round(sq, 3)));

            Console.ReadLine();
        }
    }
}