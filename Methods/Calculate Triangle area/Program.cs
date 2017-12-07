using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Triangle_area
{
    class Program
    {
        static double TriangleArea(double lenght, double height)
        {
            return lenght * height / 2;
        }
        static void Main()
        {
            double lenght = double.Parse(Console.ReadLine());
            double height= double.Parse(Console.ReadLine());
            double area=TriangleArea(lenght, height);
            Console.WriteLine(area);
        }
    }
}
