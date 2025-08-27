using System;

namespace ProgrammingHub
{
    class KeithNumber
    {
        public static void Main()
        {
            int i;

            Console.Write("Enter the number : ");

            int n = Convert.ToInt32(Console.ReadLine());

            int copy = n;
            String s = n.ToString();

            //finding the number of digits (d) in the number
            int d = s.Length;

            //array for storing the terms of the series
            int[] arr = new int[n];

            for (i = d - 1; i >= 0; i--)
            {
                //storing the digits of the number in the array
                arr[i] = copy % 10;
                copy = copy / 10;
            }

            i = d;
            int sum = 0;

            //finding the sum till it is less than the number
            while (sum < n)
            {
                sum = 0;

                //loop for generating and adding the previous 'd' terms
                for (int j = 1; j <= d; j++)
                {
                    sum = sum + arr[i - j];
                }

                //storing the sum in the array
                arr[i] = sum;
                i++;
            }

            //if sum is equal to the number, then it is a Keith number
            if (sum == n)
                Console.WriteLine("\n" + n + " is a Keith Number");
            else
                Console.WriteLine("\n" + n + " is a not a Keith Number");

            Console.ReadLine();
        }
    }
}