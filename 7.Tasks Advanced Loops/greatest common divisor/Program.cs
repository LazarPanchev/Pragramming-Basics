using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greatest_common_divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            var minNumber = Math.Min(a, b);
            var gcd = 1;
            for (int i = 2; i <=minNumber; i++)
            {
                if ((a%i==0) && (b%i==0))
                {
                    gcd = i;
                }

            }
            Console.WriteLine(gcd);

        }
    }
}
