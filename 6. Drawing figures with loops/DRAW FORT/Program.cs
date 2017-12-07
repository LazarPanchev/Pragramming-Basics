using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRAW_FORT
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var width = 2 * n;
            var hight = n;
            var midsize = width - (2 * (n / 2) + 4);

            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', n / 2), new string('_', midsize));

            for (int i = 0; i < n - 2; i++)
            {
                if (i == (n - 2) - 1)
                {
                    Console.Write("|");
                    Console.Write("{0}{1}{0}", new String(' ', (width - midsize - 2) / 2), new string('_', midsize));
                    Console.WriteLine("|");
                }
                else
                {
                    Console.Write("|");
                    Console.Write(new string(' ', width - 2));
                    Console.WriteLine("|");
                }
            }
            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', n / 2), new string(' ', midsize));

        }
    }
}
