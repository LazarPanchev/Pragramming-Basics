using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invalid_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool number1 = (((number >= 100) && (number <= 200)) || number == 0);
            if (!number1)
                Console.WriteLine("invalid");
        }
    }
}
