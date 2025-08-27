using System;

namespace ProgrammingHub
{
    class HappyNumber
    {
        int n;
        HappyNumber()
        {
            n = 0;
        }

        void getnum(int num)
        {
            n = num;
        }

        int sum_sq_digits(int x)
        {
            if (x == 0)
                return 0;
            else
            {
                int d = x % 10;
                return (d * d + sum_sq_digits(x / 10));
            }
        }

        void isHappyNumber()
        {
            int a = sum_sq_digits(n);
            while (a > 9)
            {
                a = sum_sq_digits(a);
            }
            if (a == 1)
                Console.WriteLine("\n" + n + " is a Happy Number");
            else
                Console.WriteLine("\n" + n + " is not a Happy Number");
        }

        public static void Main()
        {
            HappyNumber ob = new HappyNumber();

            Console.Write("Enter any number : ");
            int b = int.Parse(Console.ReadLine());

            ob.getnum(b);
            ob.isHappyNumber();

            Console.ReadLine();
        }
    }
}