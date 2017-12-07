using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_in_range_1._._100
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while(n<1 || n>100)
            {
                
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(n);
        }
    }
}
