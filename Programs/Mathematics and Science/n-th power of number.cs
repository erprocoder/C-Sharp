using System;

namespace ProgrammingHub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the base value : ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter the exponent(power) value : ");
            int exp = Convert.ToInt32(Console.ReadLine());

            double x = Power(number, exp);
            Console.WriteLine("\nThe value of " + number + " raised to the power " + exp + " is : " + x);

            Console.ReadLine();
        }

        internal static double Power(double @base, int exponent)
        {
            if (exponent < 0)
            {
                Console.Error.WriteLine("Usage of this function is limited to positive exponents only");
                throw new Exception();
            }
            else if (exponent == 1)
            {
                return @base;
            }
            else if (exponent == 0)
            {
                return 1;
            }
            else
            {
                return @base * Power(@base, exponent - 1);
            }
        }
    }
}