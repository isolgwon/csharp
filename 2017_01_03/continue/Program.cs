using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace @continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int sum = 0;
            while (i < 100)
            {
                i++;
                if (i % 2 == 0)
                    continue;
                sum = sum + i;
            }
            Console.WriteLine(
                "1~100중에 홀수들의 합 = {0}", sum);
        }
    }
}
