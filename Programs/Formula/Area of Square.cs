using System;

namespace Formula
{
    class AreaOfSquare
    {
        public static void Main()
        {
            int side, area;

            Console.Write("Enter value of the sides of square : ");
            side = Convert.ToInt32(Console.ReadLine());

            area = side * side;

            Console.WriteLine("\nArea of Square : " + area);
            Console.ReadLine();
        }
    }
}