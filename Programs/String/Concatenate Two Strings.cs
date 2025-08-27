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
            string s1 = "Hello";
            string s2 = "World";
            
            string s3 = string.Concat(s1, s2);
            
            Console.WriteLine(s3);
            Console.ReadLine();
        }
    }
}