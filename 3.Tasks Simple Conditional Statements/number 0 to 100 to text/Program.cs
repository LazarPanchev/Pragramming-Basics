using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba_greshka_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = double.Parse(Console.ReadLine());
            double success = double.Parse(Console.ReadLine());
            double minimalsalary = double.Parse(Console.ReadLine());

            var social = 0.0;
            var exellent = 0.0;

            if (salary < minimalsalary && success > 4.5)
            {
                social = 0.35 * minimalsalary;
            }
            if (success >= 5.50)
            {
                exellent = success * 25;
            }
            if (social == 0 && exellent == 0)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (social > exellent)
            {
                Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(social));
            }
            else if (exellent > social)
            {
                Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(exellent));
            }
        }
    }
}
