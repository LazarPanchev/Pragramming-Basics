using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba_greshka2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double EvenSum = 0.0;
            double EvenMax = double.MinValue;
            double EvenMin = double.MaxValue;
            double OddSum = 0.0;
            double OddMax = double.MinValue;
            double OddMin = double.MaxValue;

            for(int i=1; i<=n; i++)
            {
                double currN = double.Parse(Console.ReadLine());
                if(i%2==0)
                {
                    EvenSum += currN; 
                    if(currN>EvenMax)
                    {
                        EvenMax = currN;
                    }
                    if(currN<EvenMin)
                    {
                        EvenMin = currN;
                    }
                }
                else
                {
                    OddSum += currN;
                    if (currN > OddMax)
                    {
                        OddMax = currN;
                    }
                    if (currN < OddMin)
                    {
                        OddMin = currN;
                    }
                }
            }
            
            Console.WriteLine("OddSum={0}",OddSum);
            if(OddMin==double.MaxValue)
            {
                Console.WriteLine("OddMin=No");

            }
            else
            {
            Console.WriteLine("OddMin={0}", OddMin);

            }
            if(OddMax== double.MinValue)
            {
                Console.WriteLine("OddMax=No");

            }
            else
            {
            Console.WriteLine("OddMax={0}", OddMax);

            }
            Console.WriteLine("EvenSum={0}", EvenSum);
            if (EvenMin == double.MaxValue)
            {
                Console.WriteLine("EvenMin=No");

            }
            else
            {

                Console.WriteLine("EvenMin={0}", EvenMin);
            }
            if (EvenMax== double.MinValue)
            {
                Console.WriteLine("EvenMax=No");

            }
            else
            {
            Console.WriteLine("EvenMax={0}", EvenMax);

            }
           







        }
    }
}
