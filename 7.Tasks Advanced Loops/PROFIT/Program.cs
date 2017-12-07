using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROFIT
{
    class Program
    {
        static void Main(string[] args)
        {

            int coins1lev = int.Parse(Console.ReadLine());
            int coins2levs = int.Parse(Console.ReadLine());
            int banknote5levs = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int c1lv = 0; c1lv <= coins1lev; c1lv++)
            {
                for (int c2lv = 0; c2lv <= coins2levs; c2lv++)
                {
                    for (int l = 0; l <= banknote5levs; l++)
                    {

                        var levasum = c1lv * 1 + c2lv * 2 + l * 5;
                        if (levasum == sum)
                        {
                            Console.WriteLine("{0} * 1 lv. + {1} * 2 lv. + {2} * 5 lv. = {3} lv.", c1lv, c2lv, l, sum);

                        }

                    }



                }

            }
        }
    }
}
