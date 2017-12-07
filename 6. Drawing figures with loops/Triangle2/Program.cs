using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var width = (4 * n) + 1;
            var height = (2 * n) + 1;

            Console.WriteLine("{0}", new string('#',width ));
            var leftRightDots = 1;
            var middleDots = 1;
            var hash = (width - 3) / 2;
            for (int i = 0; i < n; i++)
            {
                if (i== (n/2))
                {
                    Console.Write(new string('.', leftRightDots));
                    Console.Write(new string('#', hash));
                    Console.Write(new string(' ', (middleDots-2)/2));
                    Console.Write("(@)");
                    Console.Write(new string(' ', (middleDots -2) / 2));
                    Console.Write(new string('#', hash));
                    Console.WriteLine(new string('.', leftRightDots));
                }
                else
                {
                        
                    Console.Write(new string('.',leftRightDots));
                    Console.Write(new string('#', hash));
                    Console.Write(new string(' ', middleDots));
                    Console.Write(new string('#', hash));
                    Console.WriteLine(new string('.', leftRightDots));
                }

                leftRightDots++;
                middleDots += 2;
                hash -= 2;

            }
            leftRightDots = n + 1;
            hash = (2 * n) - 1;
            for (int i = 0; i < n; i++)
            {

                Console.Write(new string('.', leftRightDots));
                Console.Write(new string('#', hash));
                Console.WriteLine(new string('.', leftRightDots));
                leftRightDots++;
                hash -= 2;

            }
        }
    }
}
