using System;

namespace _3_Struct
{
    struct Student
    {
        public string Name;
        public int stNum;
    }
    class Program
    {    
        static void Main(string[] args)
        {
            Student b;
            b.Name = "홍길동";
            b.stNum = 902252;
            Console.WriteLine("{0}, {1}", b.Name, b.stNum);
        }
    }
}
