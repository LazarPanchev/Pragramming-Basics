using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CROSSING_SEQUENCES
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            int N3 = int.Parse(Console.ReadLine());

            int spiral = int.Parse(Console.ReadLine());
            int spiralStep = int.Parse(Console.ReadLine());
            bool y = false;
            bool n = false;
            var Nnext=0;
            var counter = 0;

            var spiralsum = spiral;
            while(true)
            {
                 Nnext = N1 + N2 + N3;
                N1 = N2;
                N2 = N3;
                N3 = Nnext;
                if (y)
                    break;
                while(true)
                {
                    spiralsum += spiralStep;
                    counter++;
                    if (counter >= 1000000)
                        n = true;
                        
                    
                    if (Nnext == spiralsum)
                    {
                        y = true;
                        break;
                    }
                    break;

                }

            }
            if(y)
                Console.WriteLine($"{Nnext}");
            if(n)
                Console.WriteLine("No.");

            



        }
    }
}
