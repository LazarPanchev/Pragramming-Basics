using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUPID_PASSWORD_GENERATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int I = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= n; k++)
                {
                    for (char l = 'a'; l < 'a' + I; l++)
                    {

                        for (char l2 = 'a'; l2 < 'a' + I; l2++)
                        {
                            for (int g = 1; g <= n; g++)
                            {
                                if ((g > k) && (g > i))
                                {
                                    Console.Write($"{i}{k}{l}{l2}{g} ");
                                }
                            }


                        }
                    }



                }



            }
        }
    }
}
