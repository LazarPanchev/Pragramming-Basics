using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_to_Base
{
    class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            string result = ConvertToBase(number, toBase);

            Console.WriteLine(result);
        }

        public static string ConvertToBase(int number, int toBase)
        {
            string remainder = string.Empty;
            string result = string.Empty;

            while (number > 0)
            {
                remainder = (number % toBase).ToString();
                result = result.Insert(0, remainder);
                number /= toBase;
            }

            return result;
        }
    }
}
