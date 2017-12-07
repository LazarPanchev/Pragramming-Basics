using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five_Special_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            bool have = false;
            var multy = 1;
            var weight = 0;

            for(char i='a'; i<='e'; i++)
            {
                for (char j = 'a'; j <='e'; j++)
                {
                    for (char k = 'a'; k <='e'; k++)
                    {
                        for (char l = 'a'; l <='e'; l++)
                        {
                            for (char m = 'a'; m <='e'; m++)
                            {
                                string pattern = "" +i + j + k + l + m;
                                string finalPattern = "" +i;
                                if(j != i)
                                {
                                    finalPattern += j;
                                }
                                if((k != i) && (k !=j))
                                {
                                    finalPattern += k;
                                }
                                if ((l != i) && (l != j) && (l != k))
                                {
                                    finalPattern += l;
                                }
                                if ((m != i) && (m != j) && (m != k) && (m != l))
                                {
                                    finalPattern += m;
                                }
                                for (int q = 0; q <finalPattern.Length; q++)
                                {
                                    switch (finalPattern[q])
                                    {
                                        case 'a': weight += multy * 5; break;
                                        case 'b': weight += multy * -12; break;
                                        case 'c': weight += multy * 47; break;
                                        case 'd': weight += multy * 7; break;
                                        case 'e': weight += multy * -32; break;

                                    }
                                    multy++;
                                }
                                if((weight>=startNum) && (weight<=endNum))
                                {
                                     Console.Write(pattern + " ");
                                     have = true;
                                }
                                multy = 1;
                                weight = 0;                                
                            }
                        }
                    }
                }
            }
            if(!have)
                Console.WriteLine("No");

        }
    }
}
