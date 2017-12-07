using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUTTERFLY
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var width = (2 * n) - 1;
            var hight = (2 * (n - 2)) + 1;

            for (int i = 1; i <= n-2; i++)
            {
                
                if(i%2==0)
                {
                    Console.WriteLine("{0}\\ /{0}", new string('-', n - 2));
                }
                else
                    Console.WriteLine("{0}\\ /{0}", new string('*', n - 2));

            }
            Console.Write(new string(' ',width/2));
            Console.Write("@");
            Console.WriteLine(new string(' ', width / 2));
            for (int i = 1; i <= n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}/ \\{0}", new string('-', n - 2));
                }
                else
                    Console.WriteLine("{0}/ \\{0}", new string('*', n - 2));
            }
        }
    }
}
