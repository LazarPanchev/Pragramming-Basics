using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace half_sum_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double max = int.MinValue;
            double sum = 0;
            for(int i=0; i<n;i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
                if(currentNumber>max)
                {
                    max = currentNumber;
                }
            }
            if(max==sum/2.0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}",max);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}",Math.Abs(max-(sum-max)));
            }
            
        }
    }
}
