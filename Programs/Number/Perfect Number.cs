using System;

namespace ProgrammingHub
{
    class PerfectNumber
    {
        public static void Main()
        {
            int number, sum = 0, n;

            Console.Write("Enter the Number : ");
            number = int.Parse(Console.ReadLine());

            n = number;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }

            if (sum == n)
            {
                Console.WriteLine("\n" + number + " is a Perfect Number");
            }
            else
            {
                Console.WriteLine("\n" + number + " is not a Perfect Number");
            }

            Console.ReadLine();
        }
    }
}