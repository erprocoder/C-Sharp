using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class ConditionalStatementProgram
    {
        static void Main()
        {
            int number;

            number = 0;

            //normal if
            if (number == 0)
            {
                Console.WriteLine("The number is 0"); //this line will be executed only when the value of the number is 0
            }

            //if else
            if (number < 0)
            {
                Console.WriteLine("The number is less than 0"); //this line will be executed only when the value of the number is less than 0
            }
            else
            {
                Console.WriteLine("The number is greater than or equal to 0");
            }

            //if elseif
            if (number < 0)
            {
                Console.WriteLine("The number is less than 0");
            }
            else if(number >0)
            {
                Console.WriteLine("The number is greater than 0");
            }
            else
            {
                Console.WriteLine("The number is 0");
            }

            //just to keep the console active
            Console.ReadKey();

        }
    }
}