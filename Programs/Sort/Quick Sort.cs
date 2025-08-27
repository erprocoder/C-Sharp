using System;

namespace ProgrammingHub
{
    class QuickSortProgram
    {
        public static void QuickSort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int q = Partition(input, left, right);
                QuickSort(input, left, q - 1);
                QuickSort(input, q + 1, right);
            }
        }

        private static int Partition(int[] input, int left, int right)
        {
            print(input);
            // put the chosen pivot at input[right]
            int pivot = input[right];
            int temp;

            int i = left;
            // Compare remaining array elements against pivot = input[right]
            for (int j = left; j < right; j++)
            {
                // Move pivot to its final place
                if (input[j] <= pivot)
                {
                    temp = input[j];
                    input[j] = input[i];
                    input[i] = temp;
                    i++;
                }
            }

            input[right] = input[i];
            input[i] = pivot;

            return i;
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
            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine("Sorting Process ends:");
            Console.WriteLine("After Sorting");
            print(arr);
            //keeps the console open till any key is entered
            Console.ReadKey();

        }
    }
}