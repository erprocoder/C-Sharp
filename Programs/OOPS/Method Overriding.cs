using System;

namespace MethodOverridingTest
{
    class MethodOverridingTest
    {
        static void Main(string[] args)
        {
            A a;

            a = new A();
            a.display();

            a = new B();
            a.display();

            a = new C();
            a.display();

            Console.ReadLine();
        }
    }

    class A
    {
        public virtual void display()
        {
            Console.WriteLine("A");
        }
    }

    class B : A
    {
        public override void display()
        {
            Console.WriteLine("B");
        }
    }

    class C : A
    {
        public override void display()
        {
            Console.WriteLine("C");
        }
    }
}