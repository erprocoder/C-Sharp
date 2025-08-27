using System;

namespace ProgrammingHub
{
    class LucasSeries
    {
        public static void Main()
        {
            int num1, num2, limit, add;

            Console.Write("Enter the limit of the series : ");
            limit = Convert.ToInt32(Console.ReadLine());

            num1 = 2;
            num2 = 1;

            Console.WriteLine("\nLucas Series:");

            while (limit >= num1)
            {
                Console.Write(num1 + " ");

                add = num1 + num2;
                num1 = num2;
                num2 = add;
            }
            Console.ReadLine();
        }
    }
}