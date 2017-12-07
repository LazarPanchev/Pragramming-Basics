using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIGITS
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var n3 = n % 10;
            var n2 = (n / 10) % 10;
            var n1 = (n / 100) % 10;
            var N = n1 + n2;
            var M = n1 + n3;
            for (int i = 0; i < N; i++)
            {
                for (int k = 0; k < M; k++)
                {


                    if (n % 5 == 0)
                    {
                        n = n - n1;
                    }
                    else if (n % 3 == 0)
                    {
                        n = n - n2;
                    }
                    else
                    {
                        n = n + n3;
                    }
                    Console.Write("{0} ", n);

                }
                Console.WriteLine();

            }
        }
    }
}
