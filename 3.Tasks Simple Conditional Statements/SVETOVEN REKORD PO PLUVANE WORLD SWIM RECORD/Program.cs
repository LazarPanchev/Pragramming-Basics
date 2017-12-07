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
            double record = double.Parse(Console.ReadLine());
            double lenghtMeter = double.Parse(Console.ReadLine());
            double timeSecFor1meter = double.Parse(Console.ReadLine());

            var timeIvancho = lenghtMeter * timeSecFor1meter;
            var ressistance = Math.Floor(lenghtMeter / 15);
            var timetotal = timeIvancho + (ressistance * 12.5);

            if (timetotal < record)
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:f2} seconds.", timetotal);

            }
            else
            {
                Console.WriteLine("No, he failed! He was {0:f2} seconds slower.", timetotal - record);
            }
        }
    }
}
