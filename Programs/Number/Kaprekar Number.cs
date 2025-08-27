using System;

namespace ProgrammingHub
{
    class KaprekarNumber
    {
        int digitcount(int x)
        {
            int digit = 0;

            while (x != 0)
            {
                digit++;
                x /= 10;
            }
            return digit;
        }

        public static void Main()
        {
            int n, quo, rem, sq, temp;
            int digits;

            KaprekarNumber ob = new KaprekarNumber();

            Console.Write("Enter a number : ");
            n = Convert.ToInt32(Console.ReadLine());

            sq = n * n;

            digits = ob.digitcount(n * n);

            quo = sq / (int)Math.Pow(10, digits / 2);
            rem = sq % (int)Math.Pow(10, digits / 2);

            temp = quo + rem;

            if (temp == n)
                Console.WriteLine("\n" + n + " is a Kaprekar Number \n");
            else
                Console.WriteLine("\n" + n + " is not a kaprekar Number");

            Console.ReadLine();
        }
    }
}