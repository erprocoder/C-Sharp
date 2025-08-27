using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeCub
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter a number : ");
            i = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
                Console.Write(i+" is an Even Number");
            else
                Console.Write(i+" is an Odd Number");

            Console.Read();
        }
    }
}