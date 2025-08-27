using System;

namespace Formula
{
    class CubeRoot
    {
        public static void Main()
        {
            double num, res;

            Console.Write("Enter the Number : ");
            num = double.Parse(Console.ReadLine());

            res = Math.Round((Math.Pow(num, (double)1 / 3)),2);

            Console.Write("\nCube Root of " + num + " is " + res);

            Console.ReadLine();
        }
    }
}