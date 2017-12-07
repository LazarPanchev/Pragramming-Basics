using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HISTOGRAM
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());
            double num1 = 0;
            double num2 = 0;
            double num3 = 0;
            double num4 = 0;
            double num5 = 0;

            for (int i = 1; i <= n; i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                if (currNum < 200)
                {
                    num1++;
                }
                else if (currNum >= 200 && currNum <= 399)
                {
                    num2++;
                }
                else if (currNum >= 400 && currNum <= 599)
                {
                    num3++;
                }
                else if (currNum >= 600 && currNum <= 799)
                {
                    num4++;
                }
                else if (currNum >= 800)
                {
                    num5++;
                }
            }
            Console.WriteLine("{0:f2}", (num1 / n) * 100);
            Console.WriteLine("{0:f2}", (num2 / n) * 100);
            Console.WriteLine("{0:f2}", (num3 / n) * 100);
            Console.WriteLine("{0:f2}", (num4 / n) * 100);
            Console.WriteLine("{0:f2}", (num5 / n) * 100);
        }
    }
}
