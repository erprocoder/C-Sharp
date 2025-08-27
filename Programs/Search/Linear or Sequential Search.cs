using System;

namespace ProgrammingHub
{
    class LinearSearch
    {
        public static void Main()
        {
            int c, n, search;
            int[] array;

            Console.Write("Enter number of elements : ");
            n = Convert.ToInt32(Console.ReadLine());

            array = new int[n];

            Console.WriteLine("\nEnter " + n + " integers");

            for (c = 0; c < n; c++)
                array[c] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the search value : ");
            search = Convert.ToInt32(Console.ReadLine());

            for (c = 0; c < n; c++)
            {
                if (array[c] == search)     // Searching element is present
                {
                    Console.WriteLine("\n" + search + " is present at location " + (c + 1) + ".");
                    break;
                }
            }

            if (c == n)  // Searching element is absent
                Console.WriteLine("\n" + search + " is not present in array.");

            Console.ReadLine();
        }
    }
}