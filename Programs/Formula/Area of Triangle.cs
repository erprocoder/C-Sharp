using System;

namespace Formula
{
    class AreaOfTriangle
    {
        public static void Main()
        {
            double area;
            double @base;
            double height;

            Console.Write("Enter base of Triangle : ");
            @base = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nEnter height of Triangle  : ");
            height = Convert.ToDouble(Console.ReadLine());

            //area of triangle = (1/2) * base * height
            area = 0.5 * @base * height;
            Console.WriteLine("\nArea of Triangle is {0}", area);

            //This line is to hold the output screen
            Console.Read();

        }
    }
}