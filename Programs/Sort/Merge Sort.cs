using System;

namespace ProgrammingHub
{
    class MergeSortProgram
    {
        //static function-functions that are invoked without creating an object of the class
        public static void MergeSort(int[] input, int left, int right) //left- begin index right- end index
        {
            print(input);
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(input, left, middle); // split / merge left  half
                MergeSort(input, middle + 1, right); // split / merge right half

                // merge the two half runs
                int[] leftArray = new int[middle - left + 1];
                int[] rightArray = new int[right - middle];

                Array.Copy(input, left, leftArray, 0, middle - left + 1);
                Array.Copy(input, middle + 1, rightArray, 0, right - middle);

                int i = 0;
                int j = 0;
                // While there are elements in the left or right runs
                for (int k = left; k < right + 1; k++)
                {
                    // If left run head exists and is <= existing right run head.
                    if (i == leftArray.Length)
                    {
                        input[k] = rightArray[j];
                        j++;
                    }
                    else if (j == rightArray.Length)
                    {
                        input[k] = leftArray[i];
                        i++;
                    }
                    else if (leftArray[i] <= rightArray[j])
                    {
                        input[k] = leftArray[i];
                        i++;
                    }
                    else
                    {
                        input[k] = rightArray[j];
                        j++;
                    }
                }
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
            //invokation of static function within the same class needs not object reference or class name
            MergeSort(arr,0,arr.Length-1);
            Console.WriteLine("Sorting Process ends:");
            Console.WriteLine("After Sorting");
            print(arr);
            //keeps the console open till any key is entered
            Console.ReadKey();

        }
    }
}