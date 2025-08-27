using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CreativeCub
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayList al = new ArrayList { "Hello", 10, "World", false, 100, "Good Morning" };
            var onlyStr = al.OfType<string>();
            Console.WriteLine("Printing only strings ->\n");
            foreach (var str in onlyStr)
                Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}