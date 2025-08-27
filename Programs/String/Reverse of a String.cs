using System;

namespace ProgrammingHub
{
    class ReverseString
    {
        public static void Main()
        {
            String original, reverse = "";

            Console.Write("Enter a string to reverse : ");
            original = Console.ReadLine();

            int length = original.Length;

            for (int i = length - 1; i >= 0; i--)
                reverse = reverse + original[i];

            Console.WriteLine("\nReverse of " + original + " is : " + reverse);

            Console.ReadLine();
        }
    }
}