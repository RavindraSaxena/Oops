using System;

namespace OopsDemo
{
    public class A
    {
        public virtual void Method1()
        {
            Console.WriteLine("A - Method1");
        }
        public void Method2()
        {
            Console.WriteLine("A - Method2");
        }

        public void Method3()
        {
            Console.WriteLine("A - Method3");
        }

    }

    public class B : A
    {
        public override void Method1()
        {
            Console.WriteLine("B - Method1");
        }
        public void Method2()
        {
            Console.WriteLine("B - Method2");
        }

        public new void Method3()
        {
            Console.WriteLine("B - Method3");
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new B();
            a.Method1(); //"B - Method1"
            a.Method2(); //"A - Method2"
            a.Method3(); //"A - Method3"

            Console.ReadLine();
        }
    }
}
