using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            int startYear = int.Parse(Console.ReadLine());
            int endYear = int.Parse(Console.ReadLine());
            int magicWeight = int.Parse(Console.ReadLine());
            string format = "dd-MM-yyyy";
            bool haveMagicDate = false;
            DateTime currentDate = new DateTime(startYear, 1, 1);
            
            while (currentDate.Year<=endYear)
            {
                int d1 = currentDate.Day / 10;
                int d2 = currentDate.Day % 10;
                int d3 = currentDate.Month / 10;
                int d4 = currentDate.Month % 10;
                int d5 = currentDate.Year / 1000;
                int d6 = (currentDate.Year / 100) % 10;
                int d7 = (currentDate.Year / 10) % 10;
                int d8 = currentDate.Year % 10;
                var dateWeight = d1 * (d2 + d3 + d4 + d5 + d6 + d7 + d8) + d2 * (d3 + d4 + d5 + d6 + d7 + d8) + d3 * (d4 + d5 + d6 + d7 + d8) + d4 * (d5 + d6 + d7 + d8) + d5 * (d6 + d7 + d8) + d6 * (d7 + d8) + d7 * (d8);
                    if(dateWeight==magicWeight)
                     {
                    haveMagicDate = true;
                         Console.WriteLine(currentDate.ToString(format));
                     }

                currentDate = currentDate.AddDays(1);
            }
            if(!haveMagicDate)
            {
                Console.WriteLine("No");
            }
        }
    }
}
