using System;

namespace ProgrammingHub
{
    class ReverseNumber
    {
        public static void Main()
        {
            int reverse = 0, number = 0;

            Console.Write("Enter number to Reverse : ");
            number = Convert.ToInt32(Console.ReadLine());

            while (number != 0)
            {
                reverse = (reverse * 10) + (number % 10);
                number = number / 10;
            }
            Console.WriteLine("\nReverse of a number : " + reverse);

            Console.ReadLine();
        }
    }
}