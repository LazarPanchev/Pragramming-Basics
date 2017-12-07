using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER_GENERATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int specialNum = int.Parse(Console.ReadLine());
            int controlNum = int.Parse(Console.ReadLine());


            for (int i = M; i >= 1; i--)
            {
                for (int i2 = N; i2 >= 1; i2--)
                {
                    for (int i3 = L; i3 >= 1; i3--)
                    {
                        if (specialNum >= controlNum)
                        {
                            Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNum}.");
                            return;
                        }
                        var number = i * 100 + i2 * 10 + i3 * 1;

                        if (number % 3 == 0)
                        {
                            specialNum += 5;
                            continue;
                        }
                        if (number % 10 == 5)
                        {
                            specialNum -= 2;
                            continue;
                        }
                        if (number % 2 == 0)
                        {
                            specialNum *= 2;
                            continue;
                        }



                    }
                }
            }
            Console.WriteLine($"No! {specialNum} is the last reached special number.");

        }
}
}
