using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_Enum
{
    class Program
    {
        enum SEASON { Spring, Summer, Fall, Winter }
        static void Main(string[] args)
        {
            SEASON season;
            season = SEASON.Fall;
            Console.WriteLine(season);
            int Value = (int)season;
            Console.WriteLine(Value);
        }
    }
}
