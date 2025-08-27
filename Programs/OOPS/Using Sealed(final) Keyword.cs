using System;

namespace OOPS
{
    class SealedMethodDemo
    {
        public virtual void Method1()
        {
            Console.Write("Base class Method1");
        }
    }

    class ChildClass : SealedMethodDemo
    {
        public sealed override void Method1()
        {
            Console.Write("Derived class Method1");
        }

        public static void Main()
        {
            ChildClass c = new ChildClass();
            c.Method1();

            Console.ReadKey();
        }
    }
}