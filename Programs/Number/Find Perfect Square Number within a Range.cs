using System;

namespace ProgrammingHub
{
    class PerfectSquare
    {
        public static void Main()
        {
            int start, end, n, sum = 0;
            float s;

            Console.Write("Enter starting value of the range : ");
            start = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter ending value of the range : ");
            end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nThe Perfect Square numbers present in the range " + start + " to " + end + " are : ");

            for (int i = start; i < end; i++)
            {
                s = (float)Math.Sqrt(i);
                n = (int)Math.Floor(s);

                if (s == n)
                {
                    Console.Write(i + " ");
                    sum += i;
                }
            }

            Console.WriteLine("\n\nSum of the perfect square numbers between the range " + start + " to " + end + " are : " + sum);

            Console.ReadLine();
        }
    }
}