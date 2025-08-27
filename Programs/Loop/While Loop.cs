using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class WhileLoop
    {
        static void Main(string[] args)
        {
            int x = 1;

            while (x < 10)
            {
                Console.WriteLine("value of x : " + x);
                x++;
            }
            Console.ReadLine();
        }
    }
}