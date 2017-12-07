using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMART_LILLY
{
    class Program
    {
        static void Main(string[] args)
        {
            double Liliyears = double.Parse(Console.ReadLine());
            double Washprize = double.Parse(Console.ReadLine());
           double toyprize = double.Parse(Console.ReadLine());
            double toys = 0;
            int moneyAdd = 10;
            double moneyTotal = 0;

            for (int i = 1; i <= Liliyears; i++)
            {
                if (i % 2 == 0)
                {
                    moneyTotal = moneyTotal + (moneyAdd - 1);
                    moneyAdd = moneyAdd + 10;
                }
                else
                {
                    toys++;
                }
            }

            double totalToys = toys * toyprize;
            double totalmoney = moneyTotal + totalToys;
            if (totalmoney >= Washprize)
            {
                Console.WriteLine("Yes! {0:f2}", totalmoney - Washprize);

            }
            else
            {
                Console.WriteLine("No! {0:f2}", Washprize - totalmoney);

            }
        }
    }
}
