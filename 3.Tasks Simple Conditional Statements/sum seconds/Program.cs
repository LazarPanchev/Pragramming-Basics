using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstCompetitor = int.Parse(Console.ReadLine());
            int secondCompetitor = int.Parse(Console.ReadLine());
            int thurdCompetitor = int.Parse(Console.ReadLine());
            int Seconds = firstCompetitor + secondCompetitor + thurdCompetitor;
            int Minutes = 0;

            if (Seconds >= 180)
            {
                Minutes += 3;
                Seconds -= 180;
            }
            if (Seconds >= 120)
            {
                Minutes += 2;
                Seconds -= 120;
            }
            if (Seconds >= 60)
            {
                Minutes++;
                Seconds -= 60;
            }
            if (Seconds < 10)
            {
                Console.WriteLine(Minutes + ":" + "0" + Seconds);
            }
            else
            {
                Console.WriteLine(Minutes + ":" + Seconds);
            }
        }
    }
}
