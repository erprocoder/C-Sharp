using System;

namespace ProgrammingHub
{
    class NeonNumber
    {
        public static void Main()
        {
            Console.Write("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            int square = num * num;

            int sum = 0;

            while (square != 0)//Loop to find the sum of digits.
            {
                int a = square % 10;
                sum = sum + a;
                square = square / 10;
            }

            if (sum == num)
            {
                Console.WriteLine("\n" + num + " is a Neon Number.");
            }
            else
            {
                Console.WriteLine("\n" + num + " is not a Neon Number.");
            }

            Console.ReadLine();
        }
    }
}