using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACK_TO_THE_PAST
{
    class Program
    {
        static void Main(string[] args)
        {
            double heritage = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());
            int nowYear = 18;

            for (int y = 1800; y <= yearToLive; y++)
            {

                if (y % 2 == 0)
                {
                    heritage = heritage - 12000;
                }
                else
                {
                    heritage = heritage - (12000 + (50 * nowYear));
                }
                nowYear++;


            }
            if (heritage >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.", heritage);
            }
            else
            {
                Console.WriteLine("He will need {0:F2} dollars to survive.", Math.Abs(heritage));
            }
        }
    }
}
