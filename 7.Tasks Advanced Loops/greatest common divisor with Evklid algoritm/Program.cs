﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greatest_common_divisor_with_Evklid_algoritm
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            while(b!=0)
            {
                var oldB = b;
                b = a % b;
                a = oldB;
            }
            Console.WriteLine(a);
        }
    }
}