using System;

namespace ProgrammingHub
{
    class RepeatString
    {
        public static void Main()
        {
            int i, n;
            String strName = "";

            Console.Write("Enter your name : ");
            strName = Console.ReadLine();

            Console.Write("\nEnter the number of times you want to print your name : ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (i = 0; i < n; i++)
            {
                Console.Write(strName + " ");
            }
            Console.ReadLine();
        }
    }
}