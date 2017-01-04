using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList(10);
            ar.Add(1);
            ar.Add(2.34);
            ar.Add("string");
            ar.Add(new DateTime(2005, 3, 1));
            ar.Insert(1, 1234);
        }
    }
}
