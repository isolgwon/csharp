﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 27;
            if (i % 2 == 0)
                Console.WriteLine("i는 짝수입니다");
            else
                Console.WriteLine("i는 홀수입니다");
        }
    }
}
