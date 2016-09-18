using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // learning imolicit conversion
            //BaseClass baseClass = new BaseClass();
            //baseClass.DoSomething(); // output: Base Class

            //baseClass = new DerivedClass(); // implicit conversion; ploymorphism
            //baseClass.DoSomething(); // output: Derived class
            //DerivedClass derivedClass = new DerivedClass();
            //derivedClass.DoSomething();

            //BaseClass baseClass = derivedClass;
            //baseClass.DoSomething();

            //int aint = 3435;
            //double adouble = aint;
            //// Console.WriteLine(adouble);
           



            // learning explicit conversion
            //BaseClass baseClass = new BaseClass();
            //baseClass.DoSomething();

            //DerivedClass derivedClass = (DerivedClass)baseClass; // explicit conversion which is not possible in this case
            //derivedClass.DoSomething(); // InvalidCastException
            //double doubleNumber = 1222.436345;
            //int intNumber = (int)doubleNumber; // explicit conversion possible
            //Console.WriteLine(intNumber);


            //int exm1 = 23;
            //object anObject = exm1;


            //object bb = 435354;
            //int a = (int)bb;

            int aint = 43242;
            double adouble = aint;
            Console.WriteLine(adouble/4);

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.DoSomething();
            BaseClass baseClass = derivedClass;
            baseClass.DoSomething();

            Console.ReadKey();
        }
    }
}
