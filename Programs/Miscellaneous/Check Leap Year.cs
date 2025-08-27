using System;

namespace ProgrammingHub
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;

            Console.Write("Enter a Year : ");
            y = Convert.ToInt32(Console.ReadLine());

            if (y % 100 == 0)
            {
                if (y % 400 == 0)
                {
                    Console.WriteLine("\nThe year is a Leap year");
                }
                else
                {
                    Console.WriteLine("\nThe year is not a Leap year");
                }
            }
            else
            {
                if (y % 4 == 0)
                {
                    Console.WriteLine("\nThe year is a Leap year");
                }
                else
                {
                    Console.WriteLine("\nThe year is not a Leap year");
                }
            }
            Console.ReadLine();
        }
    }
}