using System;

namespace ProgrammingHub
{
    class RandomNumber
    {
        public static void Main()
        {
            //Random function to generated random numbers
            Random r = new Random();

            Console.WriteLine("Random number between 0 to 1000 : ");

            //Printing 10 Random number between 0 to 1000
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(r.Next(1000));
            }
            Console.ReadLine();
        }
    }
}