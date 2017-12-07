using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARROW
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var widthHight = (n * 2) - 1;
            var middle = widthHight - 4;

                Console.WriteLine("{0}{1}{0}", new string('.',(widthHight-n)/2),new string('#',n));

            for (int i = 1; i < n-1; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('.', (widthHight - n) / 2), new string('.',n-2));
            }
            Console.WriteLine("{0}{1}{0}", new string('#',(widthHight-(n-2))/2), new string('.', n-2));

            for (int i = 1; i <= n - 1; i++)
            {
                if(i==n-1)
                {
                    Console.WriteLine("{0}#{0}", new string('.',widthHight/2));
                }
                else
                {
                     Console.WriteLine("{0}#{1}#{0}", new string('.', i), new string('.', middle));
                }
                middle -= 2;
            }
        }
    }
}
