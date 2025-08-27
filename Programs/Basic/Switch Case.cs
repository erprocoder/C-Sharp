using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class SwitchCaseProgram
    {
        static void Main(string[] args)
        {

            int option = 3;
            switch (option)
            {
                // A switch section can have more than one case label.
                case 0:
                    Console.WriteLine("Case 0");
                    break;
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;

                case 4-1: //can be an expression
                    Console.WriteLine("Case 3");
                    break;
                // If the value of switchExpression is not 0,1,2,3, the
                // default case is executed.
                default:
                    Console.WriteLine("Default case (optional)");
                    break;
            }

            //just to keep the console up running
            Console.ReadKey();
        }
    }
}