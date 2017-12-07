using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUP
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var width = 5 * n;

            for (int i = 0; i < n+1; i++)
            {
                if((i>= n / 2) && (i<=n+1))
                {
                    Console.Write(new string('.', (n + i)));
                    Console.Write("#");
                    Console.Write(new string('.', ((3 * n) - (2 * i))-2));
                    Console.Write("#");

                    Console.WriteLine(new string('.', (n + i)));
                }
                else
                {

                   Console.Write(new string('.', n + i));
                   Console.Write(new string('#', (3*n)-(2*i)));
                   Console.WriteLine(new string('.', n + i));
                }
            }
            Console.WriteLine("{0}{1}{0}", new string('.', (width - n) / 2), new string('#', n));

            for (int i = 0; i <n+2; i++)
            {
                
                if(i==(n+2)/2-1)
                {
                    Console.Write(new string('.', ((width - 10) / 2)));
                    Console.Write("D^A^N^C^E^");
                    Console.WriteLine(new string('.', ((width - 10) / 2)));

                }
                else
                {
                    Console.WriteLine("{0}{1}{0}", new string('.', (width - (n + 4)) / 2), new string('#', n + 4));
                }
            }
        }
    }
}
