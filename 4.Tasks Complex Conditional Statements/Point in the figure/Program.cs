using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_the_figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool OutRectangle1 = (x < 0 || x > (3 * h)) || (y < 0 || y > (1 * h));
            bool OutRectangle2 = (x < h || x > (2 * h)) || (y < h || y > (4 * h));

            bool InRectangle1 = (x > 0 && x < (3 * h)) && (y > 0 && y < (1 * h));
            bool InRectangle2 = (x > h && x < (2 * h)) && (y > h && y < (4 * h));

            bool commonBorder = (x > h && y < 2 * h) && (y == h);

            if (OutRectangle1 && OutRectangle2)
            {
                Console.WriteLine("outside");
            }
            else if (InRectangle1 || InRectangle2 || commonBorder)
            {


                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}
