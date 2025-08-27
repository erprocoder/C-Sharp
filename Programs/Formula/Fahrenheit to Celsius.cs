using System;

namespace Formula
{
    class FahrenheitToCelsius
    {
        public static void Main()
        {

            double centigrade;
            double fahrenheit;

            Console.Write("Enter temperature in Fahrenheit : ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());

            centigrade =  (fahrenheit - 32) * (5.0 / 9.0);
            Console.WriteLine("\nTemperature in Celsius : {0}", centigrade);

            //This line is to hold the output screen
            Console.Read();
        }
    }
}