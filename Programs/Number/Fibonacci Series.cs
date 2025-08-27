using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeCub
{
    class Program
    {
        public static void Main()
        {
            int n;
            int a = 0;
            int b = 1;

            Console.Write("Enter the limit : ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a);
                int temp = a;
                a = b;
                b = temp + b;
            }

            Console.Read();
        }
    }
}