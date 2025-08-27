using System;

namespace OOPS
{
    class SuperClass
    {
        //method declared with virtual keyword
        public virtual void display()
        {
            Console.WriteLine("Hello Superclass ");
        }
    }

    class Polymorphism : SuperClass
    {
        public override void display()
        {
            Console.WriteLine("Hello Subclass ");
        }

        public static void Main()
        {
            //This is called upcasting
            SuperClass s = new Polymorphism();
            s.display();

            Console.ReadKey();
        }
    }
}