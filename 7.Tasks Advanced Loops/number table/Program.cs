using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i=0; i<n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    var number = j + i;
                    if(number>n)
                    {
                        number = n - (number - n);
                    }
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        } 
    }
}
