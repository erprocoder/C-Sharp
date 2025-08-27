using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class JaggedArrayProgram
    {
        static void Main()
        {
            // Declare the array of two elements:
            int[][] jaggedarr = new int[2][];

            // Initialize the elements:
            jaggedarr[0] = new int[4] { 1, 3, 7, 9 };
            jaggedarr[1] = new int[5] { 2, 4, 6, 8,7};

            // Display the array elements:
            for (int i = 0; i < jaggedarr.Length; i++)
            {
                System.Console.Write("Element({0}): ", i);

                for (int j = 0; j < jaggedarr[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", jaggedarr[i][j], j == (jaggedarr[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }
            // Keep the console window open in debug mode.
            System.Console.ReadKey();
        }
    }
}