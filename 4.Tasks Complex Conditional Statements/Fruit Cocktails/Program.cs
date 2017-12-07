using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Cocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string fruit = Console.ReadLine().ToLower();
            string size = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            var price = 0.00;
            
            if (fruit=="watermelon")
            {
                if(size=="small")
                {
                    price = 2 * 56;
                }
                else if(size=="big")
                {
                    price = 5 * 28.70;
                }

            }
            else if(fruit=="mango")
            {
                if (size == "small")
                {
                    price = 2 * 36.66;
                }
                else if (size == "big")
                {
                    price = 5 * 19.60;
                }
            }
            else if (fruit == "pineapple")
            {
                if (size == "small")
                {
                    price = 2 * 42.10;
                }
                else if (size == "big")
                {
                    price = 5 * 24.80;
                }
            }
            else if (fruit == "raspberry")
            {
                if (size == "small")
                {
                    price = 2 * 20;
                }
                else if (size == "big")
                {
                    price = 5 * 15.20;
                }
            }
            var total = price * quantity;
          
            if (total>=400 && total<=1000)
            {
                total = total - (0.15 * total);
            }
            else if (total>1000)
            {
                total = total - (0.50 * total);
            }
            Console.WriteLine("{0:f2} lv.", total);
        }
    }
}
