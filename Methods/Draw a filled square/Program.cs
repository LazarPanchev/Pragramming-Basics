using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_a_filled_square
{
    class Program
    {
        
        static void PrintHeaderFooter(int n)
        {
            Console.WriteLine(new string('-',2*n));
        }
        static void PrintMiddleRow(int n)
        {
            Console.Write("-");
            for (int i = 0; i < n-1; i++)
            {
                Console.Write("\\/");
            }
            Console.Write("-");
            Console.WriteLine();
        }
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            PrintHeaderFooter(input);
            for (int i = 0; i < input-2; i++)
            {
                PrintMiddleRow(input);
            }
            PrintHeaderFooter(input);

        }


    }
}
