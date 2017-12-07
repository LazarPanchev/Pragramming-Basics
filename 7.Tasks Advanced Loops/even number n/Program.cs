using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_number_n
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while(true)
            {
                if (n % 2 == 0)
                    break;


                n = int.Parse(Console.ReadLine());
                
                
            }
            Console.WriteLine(n);
        }
    }
}
