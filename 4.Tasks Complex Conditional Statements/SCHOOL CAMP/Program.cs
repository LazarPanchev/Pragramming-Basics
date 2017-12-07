using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHOOL_CAMP
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string boysGurls = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());


            var price = 0.0;
            string kindSport = "";
            if (boysGurls == "boys" && season == "Winter")
            {
                price = 9.60;
                kindSport = "Judo";
            }
            else if (boysGurls == "boys" && season == "Spring")
            {
                price = 7.20;
                kindSport = "Tennis";
            }
            else if (boysGurls == "boys" && season == "Summer")
            {
                price = 15;
                kindSport = "Football";
            }
            if (boysGurls == "girls" && season == "Winter")
            {
                price = 9.60;
                kindSport = "Gymnastics";
            }

            else if (boysGurls == "girls" && season == "Spring")
            {
                price = 7.20;
                kindSport = "Athletics";
            }
            else if (boysGurls == "girls" && season == "Summer")
            {
                price = 15;
                kindSport = "Volleyball";
            }
            if (boysGurls == "mixed" && season == "Winter")
            {
                price = 10;
                kindSport = "Ski";
            }
            else if (boysGurls == "mixed" && season == "Spring")
            {
                price = 9.50;
                kindSport = "Cycling";
            }
            else if (boysGurls == "mixed" && season == "Summer")
            {
                price = 20;
                kindSport = "Swimming";
            }
            if (students >= 50)
            {
                price -= 0.50 * price;
            }
            else if (students >= 20 && students < 50)
            {
                price -= 0.15 * price;
            }
            else if (students >= 10 && students < 20)
            {
                price -= 0.05 * price;
            }
            Console.WriteLine("{0} {1:f2} lv.", kindSport, price * nights* students);
        }
    }    }