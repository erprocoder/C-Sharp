using System;

namespace ProgrammingHub
{
    class TwinPrime
    {
        public static void Main()
        {
            int j = 0;
            int LastPrime = 1;

            Console.WriteLine("Twin Primes between 1 to 100 are : \n");

            for (int i = 1; i < 100; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                }

                if (i == j)
                {
                    if ((i - LastPrime) == 2)
                    {
                        Console.WriteLine("(" + (i - 2) + "," + i + ")");
                    }

                    LastPrime = i;
                }
            }
            Console.ReadLine();
        }
    }
}