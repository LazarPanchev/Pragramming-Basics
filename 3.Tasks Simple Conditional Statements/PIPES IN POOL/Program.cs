using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIPES_IN_POOL
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            double pipe1 = double.Parse(Console.ReadLine());
            double pipe2 = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double volpipe1 = pipe1 * hours;
            double volpipe2 = pipe2 * hours;
            double water = volpipe1 + volpipe2;
            if (water <= volume)
            {
                Console.WriteLine("The pool is {0}% full. Pipe1: {1}%. Pipe1: {2}%",
                    Math.Truncate((water / volume) * 100),
                    Math.Truncate((volpipe1 / water) * 100),
                    Math.Truncate((volpipe2 / water) * 100));
            }
            else if (water > volume)
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, water - volume);
            }
        }
    }
}
