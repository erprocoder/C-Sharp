using System;

namespace ForEachLoop
{
    class ForEachLoop
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 2, 3, 4, 5, 6 };

            foreach (int a in intArray)
            {
                Console.WriteLine(a + " ");
            }
            Console.ReadLine();
        }
    }
}