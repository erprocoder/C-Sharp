using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int number1, number2;
            float div;

            Console.Write("Enter first number : ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number : ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Enter your selection: \n1.Addition \n2.Substraction \n3.Multiplication \n4.Division:\n");
            int choose;
            choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    Console.Write("Addition of " + number1 + " and " + number2 + " is " + (number1 + number2));
                    break;
                case 2:
                    Console.Write("Subtraction of " + number1 + " and " + number2 + " is " + (number1 - number2));
                    break;
                case 3:
                    Console.Write("Multiplication of " + number1 + " and " + number2 + " is " + (number1 * number2));
                    break;
                case 4:
                    div = ((float)number1) / ((float)number2);
                    Console.Write("Division of " + number1 + " and " + number2 + " is " + div);
                    break;
            }
            Console.ReadLine();
        }
    }
}