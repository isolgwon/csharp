﻿using System;
using A;

namespace A
{
    class MyClass { int i;}
}
namespace B
{
    class MyClass { double d;}
}
namespace _1_Namespace
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
