using System;
using System.Collections.Generic;

namespace ProgrammingHub
{
    class BubbleSortProgram
    {
        static void Main(string[] args)
        {
            //input array initialization that needs to be sorted
            int[] arr = { 120,23,453,123,2446,2324,5,77,4646,12 };

            int temp = 0;

            for (int write = 0; write < arr.Length; write++) //outer loop iterates n times(n is the length of the array)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++) //inner loop will iterate n-1 times
                {
                    if (arr[sort] > arr[sort + 1]) //logic: if the LHS value is greater than RHS then swap the value
                    {
                        //swap logic
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }

            //print the sorted array on console
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            //keeps the console open till any key is entered
            Console.ReadKey();
        }
    }
}