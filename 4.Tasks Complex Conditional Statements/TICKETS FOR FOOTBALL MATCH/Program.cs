using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TICKETS_FOR_FOOTBALL_MATCH
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int fans = int.Parse(Console.ReadLine());

            var transport = 0.00;
            //var price =0.00 ;
            var moneyFortickets = budget - transport;
            var tickets = 0.0;
            var total = moneyFortickets / tickets;
            if ((fans >= 1) && (fans <= 4))
            {
                transport = budget * 0.75;
            }
            else if (fans >= 5 && fans <= 9)
            {
                transport = budget * 0.60;
            }
            else if (fans >= 10 && fans <= 24)
            {
                transport = budget * 0.50;
            }
            else if (fans >= 25 && fans <= 49)
            {
                transport = budget * 0.40;
            }
            else if (fans >= 50)
            {
                transport = budget * 0.25;
            }
            if (category == "VIP")
            {
                tickets *= 499.99;
            }
            else if (category == "Normal")
            {
                tickets *= 249.99;
            }

            if (total >= fans)
            {
                Console.Write("Yes! You have {0:f2} leva left.", (total - fans) * tickets);
            }
            else
                Console.WriteLine("Not enough money! You need {0:f2} leva", Math.Abs((fans - total) * tickets));




        }
    }
}
