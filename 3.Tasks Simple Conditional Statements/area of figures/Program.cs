using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_of_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if(figure == "square")
            {
                var square = double.Parse(Console.ReadLine());
                double area = square * square;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == "rectangle")
            {
                var rectangle1 = double.Parse(Console.ReadLine());
                var rectangle2 = double.Parse(Console.ReadLine());
                var area = rectangle1 * rectangle2;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == "circle")
            {
                var circle = double.Parse(Console.ReadLine());
                double area = (circle * circle) * Math.PI;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == "triangle")
            {
                var triangle1 = double.Parse(Console.ReadLine());
                var triangle2 = double.Parse(Console.ReadLine());
                double area = (triangle1 * triangle2) / 2;
                Console.WriteLine(Math.Round(area, 3));
            }
          


        }
    }
}
