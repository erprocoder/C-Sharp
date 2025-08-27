using System;

namespace ProgrammingHub
{
    class TribonacciSeries
    {
        public static void Main()
        {
            Console.Write("Enter number till u want Tribonacci series : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int a = 0, b = 0, c = 1;
            int d = a + b + c;

            Console.WriteLine("\nTribonacci Series : ");
            Console.Write(a + " " + b + " " + c);

            for (int i = 4; i <= n; i++)
            {
                Console.Write(" " + d);
                a = b;
                b = c;
                c = d;
                d = a + b + c;
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}