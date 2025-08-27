using System;

namespace ProgrammingHub
{
    class InsertionSortProgram
    {
        //static function-functions that are invoked without creating an object of the class
        static void InsertionSort(int[] input)
        {
            //The outer loop runs over all the elements except the first one  because the single-element prefix input[0:1]
            //is trivially sorted,so the invariant that the first i+1 entries are sorted is true from the start.
            for (int i = 0; i < input.Length - 1; i++)
            {
                //The inner loop moves element input[i] to its correct place so that after the loop,
                //the first i+2 elements are sorted.
                for (int j = i + 1; j > 0; j--)
                {
                    if (input[j - 1] > input[j])
                    {
                        int temp = input[j - 1];
                        input[j - 1] = input[j];
                        input[j] = temp;
                    }
                }
                print(input);
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
            InsertionSort(arr);
            Console.WriteLine("Sorting Process ends:");
            Console.WriteLine("After Sorting");
            print(arr);
            //keeps the console open till any key is entered
            Console.ReadKey();

        }
    }
}