using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRIANGLE
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var width = (4 * n) + 1;
            var hight = (2 * n) + 1;
            var middle = 1;

            Console.WriteLine(new string('#',width));
            for (int i = 1; i <=n; i++)
            {
                if(i==(n/2)+1)
                {
                    Console.Write(new string('.', i));
                    Console.Write(new string('#', (width - ((i * 2) + middle)) / 2));
                    Console.Write(new string(' ', (middle/2)-1));
                    Console.Write("(@)");
                    Console.Write(new string(' ', (middle / 2)-1));
                    Console.Write(new string('#', (width - ((i * 2) + middle)) / 2));
                    Console.WriteLine(new string('.', i));
                }
                else
                {

                Console.Write(new string('.',i));
                Console.Write(new string('#',(width-((i*2)+middle))/2 ));
                Console.Write(new string(' ',middle ));
                Console.Write(new string('#', (width - ((i * 2) + middle))/2));
                Console.WriteLine(new string('.',i));
                }
                


                middle += 2;
            }
            middle = (n * 2) - 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.',(width-middle)/2));
                Console.Write(new string('#',middle));
                Console.WriteLine(new string('.', (width - middle) / 2));

                middle -= 2;
            }

        }
    }
}
