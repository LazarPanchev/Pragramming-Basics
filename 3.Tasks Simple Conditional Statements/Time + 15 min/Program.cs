using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double minAfter15 = minutes + 15;
            
            if (minAfter15 >= 60)
            { hour++; minAfter15 -= 60; }
            if (hour > 23)
            { hour -= 24;  }
            
            if (minAfter15 < 10)
            { Console.WriteLine(hour + ":" + "0" + minAfter15); }
            else
            { Console.WriteLine(hour + ":" + minAfter15); }
        }
    }
}
