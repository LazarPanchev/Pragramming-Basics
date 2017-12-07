using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Method
{
    class Program
    {
        static int GetMin(int a , int b)
        {  
            if(a<=b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static void Main()
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            int biggerFromOneTwo= GetMin(numOne, numTwo);
            int totalResult = GetMin(biggerFromOneTwo, numThree);
            Console.WriteLine(totalResult);

        }
    }
}
