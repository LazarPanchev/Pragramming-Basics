using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLEEPY_TOM_CAT
{
    class Program
    {
        static void Main(string[] args)
        {
            int holydays = int.Parse(Console.ReadLine());
            int workinDays = 365 - holydays;
            var totalPlayMinutes = workinDays * 63 + holydays * 127;
            var difference = Math.Abs(totalPlayMinutes - 30000);
            var hours = difference / 60;
            var minutes = difference % 60;
            if (totalPlayMinutes > 30000)               
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours , minutes);

            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }
        }
    }
}
