using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GROUP_NAME
{
    class Program
    {
        static void Main(string[] args)
        {
            char bigLetter = char.Parse(Console.ReadLine().ToUpper());
            char smallLetter1 = char.Parse(Console.ReadLine().ToLower());
            char smallLetter2 = char.Parse(Console.ReadLine().ToLower());
            char smallLetter3 = char.Parse(Console.ReadLine().ToLower());
            int digit = int.Parse(Console.ReadLine());
            var counter = 0;

            for (char l1 = 'A'; l1 <= bigLetter; l1++)
            {
                for (char s1 = 'a'; s1 <= smallLetter1; s1++)
                {
                    for (char s2 = 'a'; s2 <= smallLetter2; s2++)
                    {
                        for (char s3 = 'a'; s3 <= smallLetter3; s3++)
                        {

                            for (int d = 0; d <= digit; d++)
                            {

                                if ((l1 == bigLetter) && (s1 == smallLetter1) && (s2 == smallLetter2) && (s3 == smallLetter3) && (d == digit))
                                {
                                    break;
                                }
                                counter++;


                            }

                        }
                    }

                }

            }
            Console.WriteLine(counter);

        }
    }
}
