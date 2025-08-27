using System;
using System.Collections.Generic;


namespace ProgrammingHub
{
    class HeapSortProgram
    {
        //static function-functions that are invoked without creating an object of the class
        public static void HeapSort(int[] input)
        {
            //an unordered array input of length heapSize
            int heapSize = input.Length;
            for (int p = (heapSize - 1) / 2; p >= 0; p--)
                //Build the heap in array a input that largest value is at the root
                MaxHeap(input, heapSize, p);
            //       (The following loop maintains the invariants that input[0:end] is a heap and every element
            //         beyond end is greater than everything before it (so input[end:count] is in sorted order))
            for (int i = input.Length - 1; i > 0; i--)
            {
                //(input[0] is the root and largest value. The swap moves it in front of the sorted elements.)
                int temp = input[i];
                input[i] = input[0];
                input[0] = temp;
                //(the heap size is reduced by one)
                heapSize--;
                //(the swap ruined the heap property, so restore it)
                MaxHeap(input, heapSize, 0);
            }
        }

        private static void MaxHeap(int[] input, int heapSize, int index)
        {
            print(input);
            int left = (index + 1) * 2 - 1;
            int right = (index + 1) * 2;
            int largest = 0;
            //(The largest holds the largest element. Since we assume the heaps rooted at the
            // children are valid, this means that we are done.)
            if (left < heapSize && input[left] > input[index])
                largest = left;
            else
                largest = index;

            if (right < heapSize && input[right] > input[largest])
                largest = right;

            if (largest != index)
            {
                int temp = input[index];
                input[index] = input[largest];
                input[largest] = temp;
                //(repeat to continue sifting down the child now)
                MaxHeap(input, heapSize, largest);
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
            int[] arr = { 5,7,3,4,1};

            Console.WriteLine("Before Sorting");
            print(arr);
            Console.WriteLine("Sorting Process starts:");
            //invokation of static function within the same class needs not object reference or class name
            HeapSort(arr);
            Console.WriteLine("Sorting Process ends:");
            Console.WriteLine("After Sorting");
            print(arr);
            //keeps the console open till any key is entered
            Console.ReadKey();

        }
    }
}