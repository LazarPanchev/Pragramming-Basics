
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba_greshka
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > max)
                {
                    max = currentNumber;
                }
            }
            Console.WriteLine(max);

        }
    }
}
