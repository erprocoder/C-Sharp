using System;
using System.Collections.Generic;

namespace Array
{
    class BubbleSortProgram
    {
        static void Main(string[] args)
        {
            //input array initialization that needs to be sorted
            int[] a ;
            int size;

            Console.Write("Enter the size of array : ");
            size = int.Parse(Console.ReadLine());

            a = new int[size];

            Console.Write("\nEnter the elements of array : ");
            for (int i = 0; i < size; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nBefore Sorting, Elements of array is : \n");
            for (int i = 0; i < size; i++)
            {
                Console.Write(a[i] + " ");
            }

            int temp = 0;

            for (int write = 0; write < size; write++) //outer loop iterates n times(n is the length of the array)
            {
                for (int sort = 0; sort < size - 1; sort++) //inner loop will iterate n-1 times
                {
                    if (a[sort] < a[sort + 1]) //logic: if the LHS value is greater than RHS then swap the value
                    {
                        //swap logic
                        temp = a[sort + 1];
                        a[sort + 1] = a[sort];
                        a[sort] = temp;
                    }
                 }
            }

            //print the sorted array on console
            Console.Write("\n\nAfter Sorting, Elements of array in descending order is : \n");
            for (int i = 0; i < size; i++)
                Console.Write(a[i] + " ");
           
            //keeps the console open till any key is entered
            Console.ReadKey();
        }
    }
}