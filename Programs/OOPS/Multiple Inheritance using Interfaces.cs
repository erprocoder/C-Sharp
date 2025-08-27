using System;

namespace Inheritance
{
    interface addition
    {
        int add(int a, int b);
    }

    interface subtraction
    {
        int sub(int x, int y);
    }

    interface multiplication
    {
        int mul(int r, int s);
    }

    interface division
    {
        float div(float c, float d);
    }

    class Calculation : addition, subtraction, multiplication, division
    {
        public int result1;
        public int add(int a, int b)
        {
            return result1 = a + b;
        }

        public int result2;
        public int sub(int x, int y)
        {
            return result2 = x - y;
        }

        public int result3;
        public int mul(int r, int s)
        {
            return result3 = r * s;
        }

        public float result4;
        public float div(float c, float d)
        {
            return result4 = (float)(c / d);
        }

        static void Main(string[] args)
        {
            Calculation c = new Calculation();

            c.add(8, 2);
            c.sub(20, 10);
            c.mul(5, 2);
            c.div(2, 3);

            Console.WriteLine("Multiple Inheritance concept Using Interfaces :\n ");

            Console.WriteLine("Addition : " + c.result1);
            Console.WriteLine("Subtraction : " + c.result2);
            Console.WriteLine("Multiplication : " + c.result3);
            Console.WriteLine("Division : " + c.result4);

            Console.ReadKey();
        }
    }
}