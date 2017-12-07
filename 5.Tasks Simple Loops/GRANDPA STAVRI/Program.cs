using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRANDPA_STAVRI
{
    class Program
    {
        static void Main(string[] args)
        {
            double ndays = double.Parse(Console.ReadLine());
            double liters = 0.0;
            double totaldegree = 0.0;
            for(int i=0; i<ndays; i++)
            {
                double quantity = double.Parse(Console.ReadLine());
                double degree = double.Parse(Console.ReadLine());
                liters += quantity;
                totaldegree = totaldegree + (quantity * degree);
            }
            var sumdegree = totaldegree / liters;
            Console.WriteLine("Liter: {0:f2}",liters);
            Console.WriteLine("Degrees: {0:f2}", sumdegree);
            if(sumdegree<=38)
            {
                Console.WriteLine("Not good, you should baking!");

            }
            else if(sumdegree>38 && sumdegree<42)
            {
                Console.WriteLine("Super!");

            }
            else
            {
                Console.WriteLine("Dilution with distilled water!");

            }



        }
    }
}
