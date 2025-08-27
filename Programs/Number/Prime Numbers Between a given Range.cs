using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbersBetweentheRange
{
    class PrimeNumbersBetweentheRange
    {
        static void Main(string[] args)
        {
            int i, j, upper_limit, lower_limit, flag = 1, counter = 0;

            Console.Write("Enter the lower limit of the range : ");
            lower_limit = int.Parse(Console.ReadLine());

            Console.Write("\nEnter the upper limit of the range : ");
            upper_limit = int.Parse(Console.ReadLine());

            //logic of prime number
            Console.Write("\nThe Prime Numbers between the Range " + lower_limit + " - " + upper_limit + " are \n");
            for(i = lower_limit+1; i < upper_limit; i++)
            {
                for(j = 2; j <= i/2; j++)
                {
                    if(i % j == 0)
                    {
                        flag = 0;
                        break;
                    }      
                }

                if(flag == 1 && i != 1)
                {
                    Console.Write(i + " ");
                    counter++;
                }
                flag = 1;
            }

            Console.Write("\n\nThe Number of Prime Number between the range " + lower_limit + " - " + upper_limit + " : " + counter);
            Console.Read();
        }
    }
}