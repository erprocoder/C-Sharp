using System;

namespace Formula
{
    class InchesToFeet
    {
        public static void Main()
        {
            int inches;
            int feet;
            int inche;

            Console.Write("Enter height in inches : ");
            inches =Convert.ToInt32(Console.ReadLine());

            feet = inches / 12;
            inche = inches % 12;

            Console.WriteLine("\n{0} foot and {1} inche", feet, inche);

            //This line is to hold the output screen
            Console.Read();

        }
    }
}