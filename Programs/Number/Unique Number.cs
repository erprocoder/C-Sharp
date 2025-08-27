using System;

namespace ProgrammingHub
{
    class UniqueNumber
    {
        public static void Main()
        {
            Console.Write("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            String s = n.ToString(); //converting the number into String form
            int l = s.Length;

            int flag = 0; /* loop for checking whether there are repeated digits */

            for (int i = 0; i < l - 1; i++)
            {
                for (int j = i + 1; j < l; j++)
                {
                    if (s[i] == s[j]) //if any digits match, then we know it is not a Unique Number
                    {
                        flag = 1; break;
                    }
                }
            }

            if (flag == 0)
                Console.WriteLine("\n" + s + " is a Unique Number");
            else
                Console.WriteLine("\n" + s + " is Not a Unique Number");

            Console.ReadLine();
        }
    }
}