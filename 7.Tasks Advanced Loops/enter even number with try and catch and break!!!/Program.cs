using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enter_even_number_with_try_and_catch_and_break___
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter even number: ");
            var n = 0;

            while (true)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {

                        break;
                    }
                    Console.WriteLine("Enter even number:");

                }
                catch
                {
                    Console.WriteLine("This is not a number, please enter a number!!!");
                }

            }
            Console.WriteLine("You entered even number: " + n);

        }
    }
}
