using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            int n, i, res;
            bool flag = true;

            Console.WriteLine("Please Enter a No.");
            n = int.Parse(Console.ReadLine());

            for (i = 2; i <= n / 2; i++)
            {
                res = n % i;
                if (res == 0)
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
                Console.WriteLine(n + " is Prime Number");
    else
                Console.WriteLine(n + " is not Prime Number");

            Console.ReadLine();
        }
    }
}