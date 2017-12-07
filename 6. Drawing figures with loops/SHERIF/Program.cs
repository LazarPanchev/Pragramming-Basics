using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHERIF
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var width = 3 * n;
            var hight = (2 * n) + 8;

            Console.WriteLine("{0}x{0}", new string('.', (width-1)/2 ));
            Console.WriteLine("{0}/x\\{0}", new string('.', (width - 3) / 2));
            Console.WriteLine("{0}x|x{0}", new string('.', (width - 3) / 2));

            for (int i = 0; i <(n/2)+1; i++)
            {
                var x = (width - ((2 * (n + i)) + 1)) / 2;
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', x ), new string('x', n +i));
            }
            
            for (int i =(n/2)-1; i>=0; i--)
            {
                var x = (width - ((2 * (n + i)) + 1)) / 2;
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', x), new string('x', n + i));
            }
            Console.WriteLine("{0}/x\\{0}", new string('.', (width - 3) / 2));
            Console.WriteLine("{0}\\x/{0}", new string('.', (width - 3) / 2));
            for (int i = 0; i < (n / 2) + 1; i++)
            {
                var x = (width - ((2 * (n + i)) + 1)) / 2;
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', x), new string('x', n + i));
            }

            for (int i = (n / 2)-1; i >= 0; i--)
            {
                var x = (width - ((2 * (n + i)) + 1)) / 2;
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', x), new string('x', n + i));
            }
            Console.WriteLine("{0}x|x{0}", new string('.', (width - 3) / 2));
            Console.WriteLine("{0}\\x/{0}", new string('.', (width - 3) / 2));
            Console.WriteLine("{0}x{0}", new string('.', (width - 1) / 2));
        }
    }
}
