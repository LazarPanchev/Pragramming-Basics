using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_even_posion
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double sumeven = 0.0;
            double sumodd = 0.0;
            double maxeven = double.MinValue;
            double maxodd = double.MinValue;
            double mineven = double.MaxValue;
            double minodd = double.MaxValue;
            for (double i = 1; i <= n; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumeven += currentNumber;
                    if (currentNumber > maxeven)
                    {
                        maxeven = currentNumber;
                    }
                    else if (currentNumber < mineven)
                    {
                        mineven = currentNumber;
                    }
                    else
                    {
                        maxeven = -1;
                        mineven = -1;
                    }
                }
                else if (i % 2 > 0 || i % 2 < 0)
                {
                    sumodd += currentNumber;
                    if (currentNumber > maxodd)
                    {
                        maxodd = currentNumber;
                    }
                    else if (currentNumber < minodd)
                    {
                        minodd = currentNumber;
                    }
                    else
                    {
                        maxodd = -1;
                        minodd = -1;
                    }
                }
            }
            if (maxeven < 0 || maxodd < 0 || mineven < 0 || minodd < 0)
            {
                Console.WriteLine("OddSum={0}", sumodd);
                Console.WriteLine("OddMin={0}", minodd);
                Console.WriteLine("OddMax={0}", maxodd);
                Console.WriteLine("EvenSum={0}", sumeven);
                Console.WriteLine("EvenMin= No");
                Console.WriteLine("EvenMAx= No");
            }
            else
            {
                Console.WriteLine("OddSum={0}", sumodd);
                Console.WriteLine("OddMin={0}", minodd);
                Console.WriteLine("OddMax={0}", maxodd);
                Console.WriteLine("EvenSum={0}", sumeven);
                Console.WriteLine("EvenMin={0}", mineven);
                Console.WriteLine("EvenMAx={0}", maxeven);

            }

        }
    }
}

