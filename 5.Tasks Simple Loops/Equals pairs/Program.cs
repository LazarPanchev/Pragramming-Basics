using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equals_pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int sumnew = 0;
            int sumprevious = 0;
            int maxdifference = 0;
            int totalsum = 0;
            for (int i = 0; i < n; i++)
            {
                if(sumnew==sumprevious)
                {
                    totalsum = sumnew;
                }
                else
                {
                    maxdifference = (sumnew - sumprevious);
                }
                sumprevious = sumnew;
                

                sumnew = 0;
                  sumnew = sumnew + int.Parse(Console.ReadLine());
                  sumnew = sumnew + int.Parse(Console.ReadLine());
                  
            }
            if(maxdifference==0)
            {
                Console.WriteLine("Yes, value= " + sumnew);
            }
            else
            {
                Console.WriteLine("No, maxdiff= " + maxdifference);

            }
        }
    }
}
