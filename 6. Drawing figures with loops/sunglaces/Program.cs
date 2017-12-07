using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sunglaces
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if((i==0) || (i==n-1))
                {

                    Console.Write(new string('*', 2*n));
                    Console.Write(new string(' ',n));
                    Console.Write(new string('*', 2 * n));
                    Console.WriteLine();
                }
                
                else
                {
                    Console.Write(new string('*',1));
                    Console.Write(new string('/',(n*2)-2));
                    Console.Write(new string('*', 1));
                    if(i==(n-1)/2)
                    {
                       Console.Write(new string('|',n));
                    }
                    else
                    {
                        Console.Write(new string(' ', n));

                    }
                    Console.Write(new string('*', 1));
                    Console.Write(new string('/', (n * 2) - 2));
                    Console.Write(new string('*', 1));
                    Console.WriteLine();
                }
            }
        }
    }
}
