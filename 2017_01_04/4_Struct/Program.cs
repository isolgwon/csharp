using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Student b = new Student("홍길동", 902521);
            b.OutInfo();
        }
        struct Student
        {
            public string Name;
            public int stNum;
            public Student(string aName, int aStNum)
            {
                Name = aName;
                stNum = aStNum;
            }
            public void OutInfo()
            {
                Console.WriteLine("{0}, {1}", Name, stNum);
            }
        }
    }
}
