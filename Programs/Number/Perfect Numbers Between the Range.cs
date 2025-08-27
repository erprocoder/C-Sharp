using System;

namespace ProgrammingHub
{
    class PerfectNumberInRange
    {
        public static void Main()
        {
            int sum;

            Console.Write("Enter the start value of the range : ");
            int strt = int.Parse(Console.ReadLine());

            Console.Write("\nEnter the end value of the range : ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("\nThe Perfect Numbers between " + strt + " to " + end + " are ");

            for (int n = strt; n <= end; n++)
            {
                sum = 0;
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        sum = sum + i;
                    }
                }

                if (sum == n)
                {
                    Console.Write(n + " ");
                }
            }

            Console.ReadLine();
        }
    }
}