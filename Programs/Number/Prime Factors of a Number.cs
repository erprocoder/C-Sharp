using System;

namespace ProgrammingHub
{
    class PrimeFactors
    {
        private bool prime(int a)
        {
            bool b = true;

            for (int i = 2; i <= (a / 2); i++)
            {
                if (a % i == 0)
                    b = false;
            }
            return b;
        }

        public static void Main()
        {
            Console.Write("Enter the Number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            PrimeFactors o = new PrimeFactors();

            Console.Write("\nPrime Factors of " + a + " are : ");
            for (int i = 1; i <= (a / 2); i++)
            {
                if (a % i == 0)
                {
                    bool b = o.prime(i);
                    if (b == true)
                        Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
    }
}