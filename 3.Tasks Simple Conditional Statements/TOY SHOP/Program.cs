using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111
{
    class Program
    {
        static void Main(string[] args)
        {
            double Travellprice = double.Parse(Console.ReadLine());
            double puzzels = double.Parse(Console.ReadLine());
            double talkingdolls = double.Parse(Console.ReadLine());
            double teddybears = double.Parse(Console.ReadLine());
            double Minions = double.Parse(Console.ReadLine());
            double Trucks = double.Parse(Console.ReadLine());

            var profit = puzzels * 2.60 + talkingdolls * 3 + teddybears * 4.10 + Minions * 8.20 + Trucks * 2;
            var quantity = puzzels + talkingdolls + teddybears + Minions + Trucks;

            if (quantity >= 50)
            {
                profit = profit - (0.25 * profit);
            }
            var total = profit - (0.10 * profit);
            if (total >= Travellprice)
            {
                Console.WriteLine("Yes! {0:f2} lv left.", total - Travellprice);
            }
            else
            {
                Console.WriteLine("Not enough money! {0:f2} lv needed.", Travellprice - total);
            }
        }
    }
}
