using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THREE_BROTHERS
{
    class Program
    {
        static void Main(string[] args)
        {
            double bigbrother = double.Parse(Console.ReadLine());
            double middleBrother = double.Parse(Console.ReadLine());
            double smallBrother = double.Parse(Console.ReadLine());
            double FatherMissed = double.Parse(Console.ReadLine());

            double timeCleaning = 1 / (1 / bigbrother + 1 / middleBrother + 1 / smallBrother);
            double middletime = timeCleaning * 0.15;
            double totaltime = timeCleaning + middletime;

            Console.WriteLine("Cleaning time: {0}", Math.Round(totaltime, 2));
            double timeLeft = FatherMissed - totaltime ;

            if (timeLeft > 0)
            {
                Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.",
                Math.Floor(timeLeft));
            }
            else
            {
                
                Console.WriteLine("No, there isn't a surprise - shortage of time -> {0} hours.",
               Math.Ceiling(Math.Abs(timeLeft)));
            }
        }
    }
}
