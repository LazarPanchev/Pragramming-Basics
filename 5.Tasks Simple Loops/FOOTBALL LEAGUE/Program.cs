using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOOTBALL_LEAGUE
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            double allFans = double.Parse(Console.ReadLine());
            double sectorA = 0;
            double sectorB = 0;
            double sectorV = 0;
            double sectorG = 0;

            for (int i = 1; i <= allFans; i++)
            {
                string sector = Console.ReadLine();
                if (sector == "A")
                {
                    sectorA++;
                }
                else if (sector == "B")
                {
                    sectorB++;
                }
                else if (sector == "V")
                {
                    sectorV++;
                }
                else if (sector == "G")
                {
                    sectorG++;
                }

            }
            double sectorAper = sectorA / allFans * 100;
            double sectorBper = sectorB / allFans * 100;
            double sectorVper = sectorV / allFans * 100;
            double sectorGper = sectorG / allFans * 100;
            double sectorCapacity = allFans / capacity * 100;
            Console.WriteLine("{0:f2}%", sectorAper);
            Console.WriteLine("{0:f2}%", sectorBper);
            Console.WriteLine("{0:f2}%", sectorVper);
            Console.WriteLine("{0:f2}%", sectorGper);
            Console.WriteLine("{0:f2}%", sectorCapacity);
        }
    }
}
