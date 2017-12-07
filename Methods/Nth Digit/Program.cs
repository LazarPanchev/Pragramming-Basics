using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nth_Digit
{
    class Program
    {
        static int FindNthDigit(int number, int index)
        {
            int indexCounter = 1;
           
           while(!(number==0))
            {
                
                int digitToCheck = number % 10;
               
                if(indexCounter==index)
                {
                    return digitToCheck;
                }
                number = number / 10;
                indexCounter++;
            }
            return number;

        }
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            int result = FindNthDigit(number, index);
            Console.WriteLine(result);

        }
    }
}
