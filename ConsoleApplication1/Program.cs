﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 5;

            a = b = 5;
            a = b + 33;
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);

            Console.ReadKey();



        }
    }
}
