using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRIP
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();


            var price = 0.0;
            var night = "";
            var camp = "Camp";
            var hotel = "Hotel";

            var where = "";
            var bg = "Bulgaria";
            var balkan = "Balkans";
            var eu = "Europe";

            if (budget <= 100)
            {
                where = bg;
                if (season == "summer")
                {
                    price = 0.30 * budget;
                    night = camp;
                }
                else if (season == "winter")
                {
                    price = 0.70 * budget;
                    night = hotel;
                }
            }
            else if (budget <= 1000)
            {
                where = balkan;
                if (season == "summer")
                {
                    price = 0.40 * budget;
                    night = camp;
                }
                else if (season == "winter")
                {
                    price = 0.80 * budget;
                    night = hotel;
                }
            }
            else if (budget > 1000)
            {
                where = eu;
                price = 0.90 * budget;
                night = hotel;
            }
            Console.WriteLine("Somewhere in " + where);
            Console.WriteLine("{0} - {1:f2}", night, price);



        }
    }
}
