using System;

namespace ProgrammingHub
{
    class PositiveNegativeZero
    {
        public static void Main()
        {
            int num;
            Console.Write("Enter a Number : ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Positive Number");
            }
            else if (num < 0)
            {
                Console.WriteLine("Negative Number");
            }
            else if (num == 0)
            {
                Console.WriteLine("Zero");
            }

            //This line is to hold the output screen
            Console.Read();
        }
    }
}