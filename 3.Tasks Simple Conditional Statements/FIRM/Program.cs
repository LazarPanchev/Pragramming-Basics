using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRM
{
    class Program
    {
        static void Main(string[] args)
        {
            int projectHours = int.Parse(Console.ReadLine());
            int availableDays = int.Parse(Console.ReadLine());
            int overTimeWorkers = int.Parse(Console.ReadLine());

            var workDays = (availableDays * 8 * 0.9);
            var overtime = overTimeWorkers * 2 * availableDays ;
            var workHours = Math.Floor(workDays + overtime);

            

            if (workHours >= projectHours)
            {
                Console.WriteLine("Yes!{0} hours left.", workHours  - projectHours );
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", projectHours - workHours);
            }
        }
    }
}
