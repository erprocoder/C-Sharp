using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeCub
{

    class Program
    {
        string str;
        public void readdata()
        {
            Console.Write("Enter a String : ");
            str = Console.In.ReadLine();
        }
        public void abbre()
        {
            char[] c, result;
            int j = 0;
            c = new char[str.Length];
            result = new char[str.Length];
            c = str.ToCharArray();
            result[j++] = (char)((int)c[0] ^ 32);
            result[j++] = '.';
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (c[i] == ' ' || c[i] == '\t' || c[i] == '\n')
                {
                    int k = (int)c[i + 1] ^ 32;
                    result[j++] = (char)k;
                    result[j++] = '.';
                }
            }
            Console.Write("The Abbreviation for {0} is ", str);
            Console.WriteLine(result);
            Console.ReadLine();

        }
        public static void Main()
        {
            Program obj = new Program();
            obj.readdata();
            obj.abbre();
        }
    }
}