using System;
using System.Collections;

namespace Array
{
    class ArrayListExample
    {
        static void Main(string[] args)
        {
            //creating arraylist
            ArrayList al = new ArrayList();

            //adding object in arraylist 
            al.Add("Java");
            al.Add("C");
            al.Add("C++");
            al.Add("php");

            Console.Write("Contents of ArrayList : ");

            //Using Enhance for-loop
            foreach (String str in al)
            {
                Console.Write("\n" + str);
            }
            Console.ReadLine();
        }
    }
}