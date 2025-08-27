using System;

namespace Formula
{
    class DecimalToBinary
    {
        public static void Main()
        {
            Console.Write("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            //Decimal to binary conversion
            Console.WriteLine("\nThe Binary Representation of Decimal Number " + n +
                " is " + Convert.ToString(n, 2));

            Console.ReadKey();

        }
    }
}