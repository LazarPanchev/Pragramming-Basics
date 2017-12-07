using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_Pictures
{
    class Program
    {
        static void Main(string[] args)
        {
            int picturesNumbers = int.Parse(Console.ReadLine());
            string picKind = Console.ReadLine();
            string order = Console.ReadLine();

            
            var price = 0.0;
            if (picKind == "9X13")
            {
                price = 0.16;
                if (picturesNumbers > 50)
                {
                    price = price - (price * 0.05);
                }
            }
            else if (picKind == "10X15")
            { 
                price = 0.16;
                if (picturesNumbers > 80)
                {
                    price = price - (price * 0.03);
                }
            }
            else if (picKind == "13X18")
            {
                price = 0.38;
                if (picturesNumbers >= 50 && picturesNumbers <= 100)
                {
                    price = price - (price * 0.03);
                }
                else if(picturesNumbers>100)
                {
                    price = price - (price * 0.05);
                }
            }
            else if (picKind == "20X30")
            {
                price = 2.90;
                if (picturesNumbers >= 10 && picturesNumbers <= 50)
                {
                    price = price - (price * 0.07);
                }
                else if (picturesNumbers > 50)
                {
                    price = price - (price * 0.09);
                }
            }
            if(order=="online")
            {
                price = price - (price * 0.02);
            }
            Console.WriteLine("{0:f2}BGN", price * picturesNumbers);
        
        }
    }
}
