using System;

namespace ProgrammingHub
{
    class ShellSortProgram
    {
        static void shellSort(int[] input, int array_size)
        {
            int i, j, increment, temp;
            increment = 3;
            // Start with the largest gap and work down to a gap of 1
            while (increment > 0)
            {
                print(input);
                for (i = 0; i < array_size; i++)
                {
                    j = i;
                    temp = input[i];
                   // shift earlier gap-sorted elements up until the correct location for input[i] is found
                    while ((j >= increment) && (input[j - increment] > temp))
                    {
                        input[j] = input[j - increment];
                        j = j - increment;
                    }
                    //put temp (the original input[i]) in its correct location
                    input[j] = temp;
                }
                if (increment / 2 != 0)
                    increment = increment / 2;
                else if (increment == 1)
                    increment = 0;
                else
                    increment = 1;
            }
        }

        //function to print the array
        public static void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //input array initialization that needs to be sorted
            int[] arr = { 5, 7, 3, 4, 1 };

            Console.WriteLine("Before Sorting");
            print(arr);
            Console.WriteLine("Sorting Process starts:");
            shellSort(arr,arr.Length);
            Console.WriteLine("Sorting Process ends:");
            Console.WriteLine("After Sorting");
            print(arr);
            //keeps the console open till any key is entered
            Console.ReadKey();

        }
    }
}