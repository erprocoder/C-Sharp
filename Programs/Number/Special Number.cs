using System;

namespace ProgrammingHub
{
    class SpecialNumber
    {
        static int num;

        private void input()
        {
            Console.Write("Enter the Number to check for Special Number : ");
            num = Convert.ToInt32(Console.ReadLine());
        }

        public bool isSpecial(int n)
        {
            int spec = 0, temp = n;

            while (temp % 10 != 0)
            {
                spec += factorial(temp % 10);
                temp /= 10;
            }

            if (spec == n) return true;
            else return false;
        }

        private int factorial(int n)
        {
            if ((n == 1) || (n == 0))
                return 1;
            else
                return (n * factorial(n - 1));
        }

        public static void Main()
        {
            SpecialNumber obj = new SpecialNumber();
            obj.input();

            if (obj.isSpecial(num))
                Console.WriteLine("\n" + num + " is a Special Number");
            else
                Console.WriteLine("\n" + num + " is not a Special Number");

            Console.ReadLine();
        }
    }
}