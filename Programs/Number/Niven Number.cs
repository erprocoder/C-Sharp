using System;

namespace ProgrammingHub
{
    class NivenNumber
    {
        static void Main(string[] args)
        {
            int c, d, sum = 0;

            Console.Write("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            c = n;

            //finding sum of digits
            while (c > 0)
            {
                d = c % 10;
                sum = sum + d;
                c = c / 10;
            }

            if (n % sum == 0)
                Console.WriteLine("\n" + n + " is a Niven Number.");
            else
                Console.WriteLine("\n" + n + " is not a Niven Number.");

            Console.ReadKey();
        }
    }
}