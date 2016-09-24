using System;

namespace TestInheritance
{
    class BaseClass
    {
        public virtual void DoSomething()
        {
            Console.WriteLine("Base Class");
        }
    }

    class DerivedClass : BaseClass
    {
        public override void DoSomething()
        {
            Console.WriteLine("Derived class");
        }
    }
}
