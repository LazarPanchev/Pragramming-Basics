﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square_n_n_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 0; row < n; row++)
            {
                for(int col=0; col<n; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }
        }
    }
}
