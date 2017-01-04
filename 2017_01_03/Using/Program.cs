using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using A;
// using B;

namespace A
{
    class MyClass { int i;}
}
namespace B
{
    class MyClass { double d;}
}
namespace Using
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass objA = new MyClass();
            B.MyClass objB = new B.MyClass();
            Console.WriteLine(objA.ToString());
            Console.WriteLine(objB.ToString());
        }
    }
}
