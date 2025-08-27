using System;

namespace ProgrammingHub
{
    class GreatestNumber
    {
        public static void Main()
        {
            int num, i, temp, max;

            // Reading numbers want to be read
            Console.Write("Enter the range : ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter " + num + " number : ");
            // Reading 1st number
            max = Convert.ToInt32(Console.ReadLine());

            // Reading other number
            for (i = 1; i < num; i++)
            {
                temp = Convert.ToInt32(Console.ReadLine());
                if (temp < max)
                    continue;
                else
                    // largest number
                    max = temp;
            }

            Console.WriteLine("\nLargest Number is " + max);

            Console.ReadLine();
        }
    }
}