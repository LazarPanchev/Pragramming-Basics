using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_pyramid_2_100_100
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            int num = 1;

            while (num <= n)
            {
                for (int j = 0; j < counter; j++)
                {
                    Console.Write("{0} ", num);
                    num++;
                    if (num > n)
                    {
                        return;
                    }
                }
                counter++;
                Console.WriteLine();
            }
        }
    }
}
