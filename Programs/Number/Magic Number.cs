using System;

namespace ProgrammingHub
{
    class MagicNumber
    {
        private int input()
        {
            Console.Write("Enter a number : ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public bool isMagic(int n)
        {
            int sum = 0, flag;
            do
            {
                flag = 0;

                while (n % 10 == 0)
                    n /= 10;

                while (n % 10 != 0 || n > 0)
                {
                    sum += (n % 10);
                    n /= 10;
                }

                if (sum >= 10)
                {
                    n = sum;
                    sum = 0;
                }

                else
                    flag = 1;
            } while (flag == 0);

            if (sum == 1)
                return true;
            else
                return false;
        }

        public static void Main()
        {
            MagicNumber mn = new MagicNumber();
            int num = mn.input();

            if (mn.isMagic(num))
                Console.WriteLine("\n" + num + " is a Magic Number");
            else
                Console.WriteLine("\n" + num + " is not a Magic Number");

            Console.ReadLine();
        }
    }
}