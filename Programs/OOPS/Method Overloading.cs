using System;

namespace Method_Overloading_Test
{
    class MethodOverloadingTest
    {
        static void Main(string[] args)
        {
            MethodOverloading ob = new MethodOverloading();
            ob.display(20);
            ob.display(0.33f);
            ob.display('z');
            Console.ReadLine();
        }
    }
    class MethodOverloading
    {
        public void display(int number)
        {
            Console.WriteLine("Integer value: " + number);
        }
        public void display(float number)
        {
            Console.WriteLine("Float value: " + number);
        }
        public void display(char character)
        {
            Console.WriteLine("Character value: " + character);
        }
    }
}