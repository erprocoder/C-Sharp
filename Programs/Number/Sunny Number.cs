using System;

namespace ProgrammingHub
{
    class SunnyNumber
    {
        public static void Main()
        {
            int n, n1;
            double x;

            Console.Write("Enter number : ");
            n = Convert.ToInt32(Console.ReadLine());

            n1 = n + 1;
            x = Math.Sqrt(n1);

            if ((int)x == x)
            {
                Console.WriteLine("\n" + n + " is a Sunny Number");
            }
            else
            {
                Console.WriteLine("\n" + n + " is not a Sunny Number");
            }
            Console.ReadLine();
        }
    }
}