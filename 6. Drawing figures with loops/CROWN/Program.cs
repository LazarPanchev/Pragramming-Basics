using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CROWN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var width = (2 * n) - 1;
            var hight = (n / 2) + 4;
            var leftRightWidth = 1;
            var middle = 1;

            Console.WriteLine("@{0}@{0}@", new string(' ', (width-3)/2));
            for (int i = 0; i <(n/2)-1; i++)
            {
                if(i==0)
                {

                    Console.WriteLine("**{0}*{0}**", new string(' ', (width-5)/2));
                }
                else
                {
                   
                    
                        var form = (width - (leftRightWidth + middle + leftRightWidth + 6)) / 2; 
                        Console.Write("*");
                        Console.Write(new string('.', leftRightWidth));
                        Console.Write("*");
                        Console.Write(new string(' ',form ));
                        Console.Write("*");
                        Console.Write(new string('.', middle));
                        Console.Write("*");
                        Console.Write(new string(' ',form ));
                        Console.Write("*");
                        Console.Write(new string('.', leftRightWidth));
                        Console.WriteLine("*");

                        leftRightWidth++;
                        middle += 2;
                    


                    
                }
            }
            Console.WriteLine("*{0}*{1}*{0}*", new string('.', (n - 1) / 2), new string('.', n - 3));
            Console.WriteLine("*{0}{1}.{1}{0}*", new string('.', (n/2)), new string('*', ((n - 3)/2)));
            Console.WriteLine(new string('*', width));
            Console.WriteLine(new string('*', width));

        }
    }
}
