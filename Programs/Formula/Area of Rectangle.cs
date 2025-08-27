using System;

namespace Formula
{
    class AreaOfRectangle
    {
        public static void Main()
        {
            double width = 0;
            double height = 0;

            Console.Write("Enter rectangle height : ");
            height = double.Parse(Console.ReadLine());

            Console.Write("\nEnter rectangle width : ");
            width = double.Parse(Console.ReadLine());

            Console.Write("\nArea of Rectangle : ");
            Console.WriteLine(height * width);

            Console.Read();
        }
    }
}