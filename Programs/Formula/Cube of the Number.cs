using System;

namespace Formula
{
    class CubeOfNumber
    {
        public static void Main()
        {
            Console.Write("Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int cube = number * number * number;

            Console.Write("\nThe cube of " + number + " is " + cube);

            Console.ReadLine();
        }
    }
}