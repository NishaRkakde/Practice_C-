using System;

namespace overriding
{
    public class BaseClass
    {
        public virtual void print()
        {
            Console.WriteLine("Base class method");
        }
    }
    public class DerivedClass: BaseClass
    {
        public override void print()
        {
            Console.WriteLine("Derived class method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            BaseClass B = new DerivedClass();
            B.print();
        }
    }
}
