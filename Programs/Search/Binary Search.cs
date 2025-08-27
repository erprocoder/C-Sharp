using System;

namespace ProgrammingHub
{
    class BinarySearch
    {
        public static void Main()
        {
            int counter, num, item, first, last, middle;
            int[] array;

            //To capture user input
            Console.Write("Enter number of elements : ");
            num = Convert.ToInt32(Console.ReadLine());

            //Creating array to store the all the numbers
            array = new int[num];

            Console.WriteLine("\nEnter " + num + " integers in sorted order : ");
            //Loop to store each numbers in array
            for (counter = 0; counter < num; counter++)
                array[counter] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the search value : ");
            item = Convert.ToInt32(Console.ReadLine());

            first = 0;
            last = num - 1;
            middle = (first + last) / 2;

            while (first <= last)
            {
                if (array[middle] < item)
                    first = middle + 1;

                else if (array[middle] == item)
                {
                    Console.WriteLine("\n" + item + " found at location " + (middle + 1) + ".");
                    break;
                }
                else
                {
                    last = middle - 1;
                }
                middle = (first + last) / 2;
            }
            if (first > last)
                Console.WriteLine("\n" + item + " is not found.\n");

            Console.ReadLine();
        }
    }
}