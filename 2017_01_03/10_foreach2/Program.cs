using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_foreach2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] ar = { { 1, 2, 3 }, { 4, 5, 6 } };

            foreach (int a in ar)
            {
                Console.Write(a);
                Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
