using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_even_posion2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double OddSum = 0.0;
            double OddMax = double.MinValue;
            double OddMin = double.MaxValue;
            double EvenSum = 0.0;
            double EvenMax = double.MinValue;
            double EvenMin = double.MaxValue;

            for(int i=1; i<=num; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());
                
                if (i % 2 == 0)
                {
                    EvenSum += currentNumber;
                    if(currentNumber>EvenMax)
                    {
                        EvenMax = currentNumber;
                    }
                    if(currentNumber<EvenMin)
                    {
                        EvenMin = currentNumber;
                    }
                    
                    
                    
                }
                else 
                {
                    OddSum += currentNumber;
                    if (currentNumber > OddMax)
                    {
                        OddMax = currentNumber;
                    }
                   
                    if (currentNumber < OddMin)
                    {
                        OddMin = currentNumber;
                    }
                    
                }
            }
           
            
            Console.WriteLine("OddSum={0}", OddSum);
            if(OddMin==double.MaxValue)
            {
                Console.WriteLine("OddMin=No");
            }
            else
            {
                Console.WriteLine("OddMin={0}", OddMin);

            }
            if(OddMax==double.MinValue)

            {
                Console.WriteLine("OddMax=No");

            }
            else
            {
                Console.WriteLine("OddMax={0}", OddMax);
            }
            Console.WriteLine("EvenSum={0}", EvenSum);
            if(EvenMin ==double.MaxValue)
            {
                Console.WriteLine("EvenMin=No");

            }
            else
            {
                Console.WriteLine("EvenMin={0}",EvenMin);
            }
            if(EvenMax==double.MinValue)
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
