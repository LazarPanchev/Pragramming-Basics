using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASTLE
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var width = 2 * n;
            var hight = n;
            var middle = width - 2 * ((n / 2) + 2);
            Console.Write("/");
            Console.Write(new string('^',n/2));
            Console.Write("\\");
            Console.Write(new string('_', middle));
            Console.Write("/");
            Console.Write(new string('^', n / 2));
            Console.WriteLine("\\");

            for (int i = 1; i <=(n-2); i++)
            {
               
                if(i==(n-2))
                {
                    Console.Write("|");
                    Console.Write(new string(' ',n/2+1));
                    Console.Write(new string('_', middle));
                    Console.Write(new string(' ', n/2+1));
                    Console.WriteLine("|");

                }
                else
                {
                    Console.Write("|");
                    Console.Write(new string(' ', width - 2));
                    Console.WriteLine("|");
                }
            }   
                
            Console.Write("\\");
            Console.Write(new string('_', (n / 2)));
            Console.Write("/");
            Console.Write(new string(' ', middle));
            Console.Write("\\");
            Console.Write(new string('_', (n / 2)));
            Console.WriteLine("/");



        }
    }
}
