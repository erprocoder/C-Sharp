using System;

namespace Do_WhileLoop
{
    class DoWhileLoop
    {
        static void Main(string[] args)
        {
            int x = 1;
            do
            {
                Console.WriteLine("value of x : " + x);
                x++;
            } while (x < 10);

            Console.ReadLine();
        }
    }
}