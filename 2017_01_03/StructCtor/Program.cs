using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructCtor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student b("홍길동", 902521); // Error
            Student b = new Student("홍길동", 902521);
            b.OutInfo();
        }
    }
    struct Student
    {
        public string Name;
        public int StNum;
        public Student(string aName, int aStNum)
        {
            Name = aName;
            StNum = aStNum;
        }
        public void OutInfo()
        {
            Console.WriteLine("{0}, {1}", Name, StNum);
        }
    }
}
