using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Power
{
    class Program
    {
        static double MathPower(double numOne,double numTwo)
        {
            double result = 1d;
            for (int i = 0; i < numTwo; i++)
            {
                result *= numOne;
            }
            return result;
        }
        static void Main()
        {
            double numOne = double.Parse(Console.ReadLine());
            double numTwo= double.Parse(Console.ReadLine());
            double result = MathPower(numOne, numTwo);
            Console.WriteLine(result);
        }
    }
}
