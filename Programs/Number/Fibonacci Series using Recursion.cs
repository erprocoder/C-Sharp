using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeCub
{
    class Program
    {
       public static void Main(string[] args)
        {

            Console.Write("Enter the limit : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Fibonacci(0, 1, 1, number);
            Console.Read();
        }
        public static void Fibonacci(int a, int b, int counter, int number)
        {
            Console.WriteLine(a);
            if (counter < number) Fibonacci(b, a + b, counter + 1, number);
        }
    }
}