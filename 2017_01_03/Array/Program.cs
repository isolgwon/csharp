using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar;
            ar = new int[5];
            for (int i = 0; i < 5; i++)
            {
                ar[i] = i * 2;
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(ar[i]);
            }
        }
    }
}
