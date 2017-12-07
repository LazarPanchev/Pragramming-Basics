using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIVISION
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;


            for (int n=0; n<number; n++)
            {
                int currN = int.Parse(Console.ReadLine());
                if(currN %2 == 0)
                {
                    p2++;
                }
                if (currN % 3 == 0)
                {
                    p3++;
                }
                if (currN % 4 == 0)
                {
                    p4++;
                }
            }
            
            double p2Total = (p2 / number) * 100;
            double p3Total = (p3 / number) * 100;
            double p4Total = (p4 / number) * 100;
            Console.WriteLine("{0:f2}%", p2Total);
            Console.WriteLine("{0:f2}%", p3Total);
            Console.WriteLine("{0:f2}%", p4Total);




        }
    }
}
