using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUM_OR_MULTIPLICATION
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var counter = 0;


            for (int a = 1; a <= 30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30; c++)
                    {
                        var sum = a + b + c;
                        var multiplication = a * b * c;
                        if ((a < b) && (b < c) && (sum == N))
                        {
                            Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, sum);
                            counter++;
                        }
                        if ((a > b) && (b > c) && (multiplication == N))
                        {
                            Console.WriteLine("{0} * {1} * {2} = {3}", a, b, c, multiplication);
                            counter++;
                        }



                    }

                }

            }
            if (counter == 0)
                Console.WriteLine("No!");
        }
    }
}
