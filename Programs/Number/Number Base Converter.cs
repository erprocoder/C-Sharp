using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConverter
{
    class BaseConverter
    {
        static void Main(string[] args)
        {
            int convertnumber;
            string val;
            char ch ='y';

            Console.WriteLine("Menu \n\n1.Convert Decimal to Binary,Octal,Hexadecimal \n\n2.Convert Binary to Decimal,Octal,Hexadecimal \n\n3.Convert Octal to Decimal,Binary,Hexadecimal \n\n4.Convert Hexadecimal to Decimal,Binary,Octal");
           
            while (ch != 'n')
            {
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:

                        Console.WriteLine("\nEnter Decimal Number : ");
                        String deci = Console.ReadLine();

                        //Decimal to binary
                        convertnumber = Convert.ToInt32(deci, 10);
                        Console.WriteLine("\nDecimal to Binary : " + Convert.ToString(convertnumber, 2));

                        //Decimal to octal
                        convertnumber = Convert.ToInt32(deci, 10);
                        Console.WriteLine("\nDecimal to Octal : " + Convert.ToString(convertnumber, 8));

                        //Decimal to Hexadecimal
                        convertnumber = Convert.ToInt32(deci, 10);
                        Console.WriteLine("\nDecimal to Hexadecimal : " + Convert.ToString(convertnumber, 16));

                        break;

                    case 2:

                        Console.WriteLine("\nEnter Binary Number : ");
                        val = Console.ReadLine();

                        //Binary to Decimal
                        convertnumber = Convert.ToInt32(val, 2);
                        Console.WriteLine("\nBinary to Decimal : " + Convert.ToString(convertnumber, 10));

                        //Binary to Octal
                        convertnumber = Convert.ToInt32(val, 2);
                        Console.WriteLine("\nBinary to Octal : " + Convert.ToString(convertnumber, 8));

                        //Binary to Hexadecimal
                        convertnumber = Convert.ToInt32(val, 2);
                        Console.WriteLine("\nBinary to Hexadecimal : " + Convert.ToString(convertnumber, 16));

                        break;


                    case 3:

                        Console.WriteLine("\nEnter Octal Number : ");
                        String oct = Console.ReadLine();

                        //Octal to Decimal
                        convertnumber = Convert.ToInt32(oct, 8);
                        Console.WriteLine("\nOctal to Decimal : " + Convert.ToString(convertnumber, 10));

                        //Octal to Binary
                        convertnumber = Convert.ToInt32(oct, 8);
                        Console.WriteLine("\nOctal to Binary : " + Convert.ToString(convertnumber, 2));

                        //Octal to Hexadecimal
                        convertnumber = Convert.ToInt32(oct, 8);
                        Console.WriteLine("\nOctal to Hexadecimal : " + Convert.ToString(convertnumber, 16));

                        break;

                    case 4:

                        Console.WriteLine("\nEnter Hexadecimal Number : ");
                        String hexa = Console.ReadLine();

                        //Hexadecimal to Decimal
                        convertnumber = Convert.ToInt32(hexa, 16);
                        Console.WriteLine("\nHexadecimal to Decimal : " + Convert.ToString(convertnumber, 10));

                        //Hexadecimal to Binary
                        convertnumber = Convert.ToInt32(hexa, 16);
                        Console.WriteLine("\nHexadecimal to Binary : " + Convert.ToString(convertnumber, 2));

                        //Hexadecimal to Octal
                        convertnumber = Convert.ToInt32(hexa, 16);
                        Console.WriteLine("\nHexadecimal to Octal : " + Convert.ToString(convertnumber, 8));

                        break;
                }

                Console.WriteLine("\nDo you want to continue y or n");
                ch = char.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}