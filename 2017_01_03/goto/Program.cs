using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace @goto
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int sum = 0;
        start:
            sum = sum + i;
            i++;
            if (i <= 100)
                goto start;
            Console.WriteLine("1~100까지의 합계 = {0}", sum);
        }
    }
}
