using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("boy", "소년");
            ht.Add("girl", "소녀");
            ht["school"] = "학교";
            Console.WriteLine(ht["boy"]);
        }
    }
}
