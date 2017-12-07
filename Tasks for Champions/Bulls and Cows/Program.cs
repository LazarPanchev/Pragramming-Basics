using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulls_and_Cows
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNum = int.Parse(Console.ReadLine());
            int bulls=int.Parse(Console.ReadLine());
            int cows = int.Parse(Console.ReadLine());
           
            bool solutionFound = false;
           

            for (int digit1 = 1; digit1 <=9 ; digit1++)
            {
                for (int digit2  = 1; digit2<=9; digit2++)
                {
                    for (int digit3 = 1; digit3 <=9; digit3++)
                    {
                        for (int digit4= 1; digit4<=9; digit4++)
                        {
                            int guessDigit1 = (secretNum / 1000) % 10;
                            int guessDigit2 = (secretNum / 100) % 10;
                            int guessDigit3 = (secretNum / 10) % 10;
                            int guessDigit4 = (secretNum / 1) % 10;
                            int digitToCheck1 = digit1;
                            int digitToCheck2 = digit2;
                            int digitToCheck3 = digit3;
                            int digitToCheck4 = digit4;
                            int currentBulls = 0;
                            int currentCows = 0;

                            if(digitToCheck1 == guessDigit1)
                            {
                                currentBulls++;
                                guessDigit1 = -1;
                                digitToCheck1 = -2;
                            }
                            if (digitToCheck2 == guessDigit2)
                            {
                                currentBulls++;
                                guessDigit2 = -1;
                                digitToCheck2 = -2;
                            }
                            if (digitToCheck3 == guessDigit3)
                            {
                                currentBulls++;
                                guessDigit3 = -1;
                                digitToCheck3 = -2;
                            }
                            if (digitToCheck4 == guessDigit4)
                            {
                                currentBulls++;
                                guessDigit4 = -1;
                                digitToCheck4 = -2;
                            }
                            if(digitToCheck1==guessDigit2)
                            {
                                currentCows++;
                                guessDigit2 = -1;
                            }
                            else if(digitToCheck1==guessDigit3)
                            {
                                currentCows++;
                                guessDigit3 = -1;
                            }
                            else if (digitToCheck1 == guessDigit4)
                            {
                                currentCows++;
                                guessDigit4 = -1;
                            }
                            if (digitToCheck2 == guessDigit1)
                            {
                                currentCows++;
                                guessDigit1 = -1;
                            }
                            else if (digitToCheck2 == guessDigit3)
                            {
                                currentCows++;
                                guessDigit3 = -1;
                            }
                            else if (digitToCheck2 == guessDigit4)
                            {
                                currentCows++;
                                guessDigit4 = -1;
                            }
                            if (digitToCheck3 == guessDigit1)
                            {
                                currentCows++;
                                guessDigit1 = -1;
                            }
                            else if (digitToCheck3 == guessDigit2)
                            {
                                currentCows++;
                                guessDigit2 = -1;
                            }
                            else if (digitToCheck3 == guessDigit4)
                            {
                                currentCows++;
                                guessDigit4 = -1;
                            }
                            if (digitToCheck4 == guessDigit1)
                            {
                                currentCows++;
                                guessDigit1 = -1;
                            }
                            else if (digitToCheck4 == guessDigit2)
                            {
                                currentCows++;
                                guessDigit2 = -1;
                            }
                            else if (digitToCheck4 == guessDigit3)
                            {
                                currentCows++;
                                guessDigit3 = -1;
                            }
                            if(currentBulls==bulls && currentCows==cows)
                            {
                                if(solutionFound)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write($"{digit1}{digit2}{digit3}{digit4}");
                                solutionFound = true;
                            }
                        }
                    }
                }
            }
            if(!solutionFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}
