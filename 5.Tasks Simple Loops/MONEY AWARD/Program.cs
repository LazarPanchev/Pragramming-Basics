using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MONEY_AWARD
{
    class Program
    {
        static void Main(string[] args)
        {
            int parts = int.Parse(Console.ReadLine());
            double awardForPoint = double.Parse(Console.ReadLine());

            int points = 0;
            for (int i = 1; i <= parts; i++)
            {
                int pointsnew = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    pointsnew *= 2;
                }
                points += pointsnew;

            }
            double total = points * awardForPoint;
            Console.WriteLine("The project prize was {0:f2} lv.", total);
        }
    }
}
