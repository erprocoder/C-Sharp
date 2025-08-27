using System;

namespace ProgrammingHub
{
    class AdamNumbers
    {
        int CountNumberOfDigits(int n)
        {
            int numdgits = 0;
            do
            {
                n = n / 10;
                numdgits++;
            }
            while (n > 0);
            return numdgits;
        }

        int ReverseNumber(int n)
        {
            int i = 0, result = 0;
            int numdigits = CountNumberOfDigits(n);

            for (i = 0; i < numdigits; i++)
            {
                result *= 10;
                result += n % 10;
                n = n / 10;
            }

            return result;
        }

        static void Main(string[] args)
        {
            AdamNumbers an = new AdamNumbers();

            int i, n, rn;
            int sn, rsn, rrsn;

            Console.Write("Enter the minimum number of range : ");
            int s = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter the maximum number of range : ");
            int e = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nThe Adam Numbers between the range " + s +
                " to " + e + " : ");

            for (i = s; i < e; i++)
            {
                n = i;
                rn = an.ReverseNumber(i);

                if (n == rn)
                    continue;

                sn = n * n;
                rsn = rn * rn;
                rrsn = an.ReverseNumber(rsn);

                if (rrsn == sn)
                {
                    Console.Write("{0} ", n);
                }
            }
            Console.ReadKey();
        }
    }
}