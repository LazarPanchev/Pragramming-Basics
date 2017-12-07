using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_ROOM
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());

            var priceStudio = 0.0;
            var priceApartment = 0.0;

            if(month=="may" || month=="october")
            {
                priceStudio = 50;
                priceApartment = 65;
                if(nights>7 && nights<=13)
                {
                    priceStudio = priceStudio - (priceStudio * 0.05);
                }
                else if(nights>14)
                {
                    priceStudio = priceStudio - (priceStudio * 0.30);
                }

            }
            else if(month == "june" || month == "september")
            {
                priceStudio = 75.20;
                priceApartment = 68.70;
                if (nights > 16)
                {
                    priceStudio = priceStudio - (priceStudio * 0.20);
                }
            }
            else if (month == "july" || month == "august")
            {
                priceStudio = 76.00;
                priceApartment = 77.00;
                
            }
                if (nights>14)
            {
                priceApartment = priceApartment - (priceApartment * 0.10);
            }
            Console.WriteLine("Apartment: {0:f2} lv.", nights * priceApartment);
            Console.WriteLine("Studio: {0:f2} lv.", nights * priceStudio);
        }
    }
}
