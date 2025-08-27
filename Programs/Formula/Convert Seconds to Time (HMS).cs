using System;

namespace Formula
{
    class SecondsToTime
    {
        public static void Main()
        {
            int seconds;
            int hours;
            int minutes;
            int second;

            Console.Write("Enter time in seconds : ");
            seconds = Convert.ToInt32(Console.ReadLine());

            second = seconds % 60;
            minutes = (seconds / 60) % 60;
            hours = (seconds / 60) / 60;

            Console.WriteLine("\n{0} hours {1} minutes {2} seconds", hours, minutes,
                second);

            //This line is to hold the output screen
            Console.Read();

        }
    }
}