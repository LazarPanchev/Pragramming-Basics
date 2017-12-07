using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HARVEST
{
    class Program
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double Grapes1kvm = double.Parse(Console.ReadLine());
            int wineForSell = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            var grapes = area * 0.4;
            var grapesforwine = grapes * Grapes1kvm;
            var wine = grapesforwine / 2.5;
            var wineNeed = Math.Floor(wineForSell - wine);
            var wineLeft = Math.Ceiling(wine - wineForSell);
            var winePerWorker = Math.Ceiling(wineLeft / workers);
            if ( wine < wineForSell)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", wineNeed);

            }
            else
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", wine);
                Console.WriteLine("{0} liters left -> {1} liters per person.", wineLeft, winePerWorker);
            }
        }
    }
}
