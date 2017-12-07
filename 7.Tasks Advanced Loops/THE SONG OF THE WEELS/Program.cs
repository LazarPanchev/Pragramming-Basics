using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THE_SONG_OF_THE_WHEELS
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            var counter = 0;
            string password = string.Empty;
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if ((a < b) && (c > d) && (((a * b) + (c * d)) == M))
                            {
                                counter++;
                                if (counter == 4)
                                {
                                    password = ($"{a}{b}{c}{d}");
                                }
                                Console.Write("{0}{1}{2}{3} ", a, b, c, d);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            if (counter == 0 || counter < 4)
            {
                Console.WriteLine("No!");
            }
            else
                Console.WriteLine("Password: " + password);

        }
    }
}
