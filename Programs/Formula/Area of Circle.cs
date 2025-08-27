using System;

namespace Formula
{
    class AreaOfCircle
    {
        public static void Main()
        {
            double area;
            double radius;

            Console.Write("Enter radius of circle : ");
            radius = Convert.ToDouble(Console.ReadLine());

            area = 3.14 * radius * radius;
            Console.WriteLine("\nArea of Circle is {0}", area);

            //This line is to hold the output screen
            Console.Read();

        }
    }
}