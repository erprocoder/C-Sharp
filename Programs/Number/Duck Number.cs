using System;

namespace ProgrammingHub
{
    class DuckNumber
    {
        public static void Main()
        {
            Console.Write("Enter any number : ");
            String n = Console.ReadLine();

            int l = n.Length;
            int c = 0;
            char ch;

            for (int i = 1; i < l; i++)
            {
                ch = n[i];
                if (ch == '0')
                    c++;
            }

            char f = n[0];

            if (c > 0 && f != '0')
                Console.WriteLine("\n" + n + " is a duck number");
            else
                Console.WriteLine("\n" + n + " is not a duck number");

            Console.ReadKey();
        }
    }
}