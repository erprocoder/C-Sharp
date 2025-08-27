using System;

namespace ProgrammingHub
{
    class PrimorialNumber
    {
        public static void Main()
        {
            int num;

            Console.Write("Enter a number : ");
            num = Convert.ToInt32(Console.ReadLine());

            int res = 2, flag = 0;
            String str = "2";

            for (int i = 3; i <= num; i++)
            {
                flag = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                }

                if (flag != 1)
                {
                    res *= i;
                    str = str + " * " + i;
                }
            }
            Console.Write("\n" + num + " = " + str + " = " + res);

            Console.ReadLine();
        }
    }
}