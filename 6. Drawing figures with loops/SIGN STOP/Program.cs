using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGN_STOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int hight = (n * 2) + 2;
            int width = (n * 4) + 3;
            var startStop = (2 * n) + 1;
            var middle = (2 * n) - 1;

            Console.Write(new string('.', (width - startStop) / 2));
            Console.Write(new string('_', startStop));
            Console.WriteLine(new string('.', (width - startStop) / 2));
            for (int i = 1; i <= n+1; i++)
            {
                if (i == n + 1)
                {
                    Console.Write(new string('.', (width - 4 - middle) / 2));
                    Console.Write("//");
                    Console.Write(new string('_', (middle-5)/2));
                    Console.Write("STOP!");
                    Console.Write(new string('_', (middle - 5) / 2));
                    Console.Write("\\\\");
                    Console.WriteLine(new string('.', (width - 4 - middle) / 2));
                }
                else
                {
                    Console.Write(new string('.', (width - 4 - middle) / 2));
                    Console.Write("//");
                    Console.Write(new string('_', middle));
                    Console.Write("\\\\");
                    Console.WriteLine(new string('.', (width - 4 - middle) / 2));
                }
                middle += 2;
            }
            middle = (n * 4) - 1;
            for (int i = 1; i < hight-(n+1); i++)
            {

                Console.Write(new string('.', (width - 4 - middle) / 2));
                Console.Write("\\\\");
                Console.Write(new string('_', middle));
                Console.Write("//");
                Console.WriteLine(new string('.', (width - 4 - middle) / 2));
                middle -= 2;
            }
        }
    }
}
