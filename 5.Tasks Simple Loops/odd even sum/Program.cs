using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_even_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumodd = 0;
            int sumeven = 0;
            for(int i=0;i<n;i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumeven += number;
                }
                else
                {
                    sumodd += number;
                }
                    
            }
            if(sumodd==sumeven)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", sumeven);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(sumeven-sumodd));
            }
        }
    }
}
