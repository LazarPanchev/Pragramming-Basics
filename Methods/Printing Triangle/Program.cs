using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Triangle
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <num; i++)
            {
                PrintLine(1, i);
               
            }
            PrintLine(1, num);
            for (int i = num - 1; i > 0; i--)
            {
                PrintLine(1, i);
            }
        }
        static void PrintLine(int start, int end)
        {
            for (int i =start; i <=end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            
            
            }
    }
}
