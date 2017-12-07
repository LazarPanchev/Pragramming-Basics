using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENERGY_LOSS
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());
            double energy = 0;
            double sum = 0.0;
            for (int i = 1; i <= days; i++)
            {
                int hours = int.Parse(Console.ReadLine());

                if ((i % 2 == 0) && (hours % 2 == 0))
                {
                    energy = 68 * dancers;
                }
                else if ((!(i % 2 == 0)) && (hours % 2 == 0))
                {
                    energy = 49 * dancers;
                }
                else if ((i % 2 == 0) && (!(hours % 2 == 0)))
                {
                    energy = 65 * dancers;
                }
                else if ((!(i % 2 == 0)) && (!(hours % 2 == 0)))
                {
                    energy = 30 * dancers;
                }
                sum = sum + energy;

            }
            double neizhab = 100 * dancers * days;
            double gogo = neizhab - sum;
            double natanciornaden = (gogo / dancers) / days;
            if (natanciornaden <= 50)
            {
                Console.WriteLine("They are wasted! Energy left: {0:f2}", natanciornaden);
            }
            else
            {
                Console.WriteLine("They feel good! Energy left: {0:f2}", natanciornaden);

            }
        }
    }
}
