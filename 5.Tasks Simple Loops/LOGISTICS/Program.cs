using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGISTICS
{
    class Program
    {
        static void Main(string[] args)
        {
            int cargo = int.Parse(Console.ReadLine());
            double busprise = 0;
            double truckprise = 0;
            double trainprise = 0;
            double busweight = 0;
            double truckweight = 0;

            double trainweight  = 0;



            double totalweight = 0;


            for (int i=0; i<cargo; i++ )
            {
                int weight = int.Parse(Console.ReadLine());
                if(weight<=3)
                {
                    busprise = busprise+( weight * 200);
                    busweight = busweight + (weight);
                }
                else if ((weight > 3) && (weight<12))
                {
                    truckprise = truckprise + (weight * 175);
                    truckweight = truckweight + (weight);

                }
                else if (weight > 11)
                {
                    trainprise = trainprise + (weight * 120);
                    trainweight = trainweight + (weight);
                }
                totalweight += weight;

            }
            double totalprise = busprise + truckprise + trainprise;
            double tonstotal = totalprise / totalweight;
            Console.WriteLine("{0:f2}", tonstotal);
            Console.WriteLine("{0:f2}%", (busweight/totalweight) * 100 );
            Console.WriteLine("{0:f2}%", (truckweight / totalweight) * 100);
            Console.WriteLine("{0:f2}%", (trainweight /totalweight) * 100);


        }
    }
}
