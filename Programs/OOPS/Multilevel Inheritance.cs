using System;

namespace Inheritance
{
    class Multilevel : SuperChild
    {
        public void child()
        {
            Console.WriteLine("Level 3");
        }

        static void Main(string[] args)
        {
            Multilevel obj = new Multilevel();

            obj.super();
            obj.superchild();
            obj.child();

            Console.Read();
        }
    }

    class Super
    {
        public void super()
        {
            Console.WriteLine("Level 1");
        }
    }

    class SuperChild : Super
    {
        public void superchild()
        {
            Console.WriteLine("Level 2");
        }
    }
}