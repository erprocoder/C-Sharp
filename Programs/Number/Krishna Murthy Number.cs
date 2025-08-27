using System;

namespace ProgrammingHub
{
    class KrishnaMurthyNumber
    {
        int fact(int n)
        {
            int i, fact = 1;

            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        public static void Main()
        {
            Console.Write("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            KrishnaMurthyNumber kmn = new KrishnaMurthyNumber();

            if (kmn.isKrishnaMurthy(number))
            {
                Console.WriteLine("\n" + number + " is a Krishna Murthy Number");
            }

            else
            {
                Console.WriteLine("\n" + number + " is not a Krishna Murthy Number");
            }

            Console.ReadLine();
        }

        bool isKrishnaMurthy(int number)
        {
            int temp, k = 0;
            int n = number;

            while (number > 0)
            {
                temp = number % 10;
                k = k + fact(temp);
                number = number / 10;
            }

            if (k == n)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}