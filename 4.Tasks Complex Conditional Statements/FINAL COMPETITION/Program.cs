using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_COMPETITION
{
    class Program
    {
        static void Main(string[] args)
        {
            double dancers = double.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();

            var money = points * dancers;


            if (place == "Bulgaria")
            {
                money += 0;
            }
            else if (place == "Abroad")
            {
                money = money + (money * 0.50);
            }

            var charge = 0.0;
            if (place == "Bulgaria" && season == "summer")
            {
                charge = money * 0.05;

            }
            else if (place == "Bulgaria" && season == "winter")
            {
                charge = money * 0.08;
            }
            else if (place == "Abroad" && season == "summer")
            {
                charge = money * 0.10;
            }
            else if (place == "Abroad" && season == "winter")
            {
                charge = money * 0.15;
            }

            var total = money - charge;
            var afterCharity = 0.75 * total;
            var perEveryOne = (total - afterCharity) / dancers;
            Console.WriteLine("Charity - {0:f2}", afterCharity);
            Console.WriteLine("Money per dancer - {0:f2}", perEveryOne);
        }
    }
}
