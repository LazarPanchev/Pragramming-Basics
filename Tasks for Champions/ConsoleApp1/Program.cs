using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossingSequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int tribonachiFirst = int.Parse(Console.ReadLine());
            int tribonachiSecond = int.Parse(Console.ReadLine());
            int tribonachiThird = int.Parse(Console.ReadLine());
            int NumberSpiral = int.Parse(Console.ReadLine());
            int stepSpiral = int.Parse(Console.ReadLine());

            int tribonachiCurrent = 0;
            int spiralCurrent = 1;
            int spiralStepMul = 1;
            int counter = 1;
            bool result = false;
            bool increasePower = false;
            tribonachiCurrent = tribonachiFirst + tribonachiSecond + tribonachiThird;


            while ((tribonachiFirst <= 1000000) && (NumberSpiral <= 1000000))
            {
                if ((NumberSpiral == tribonachiFirst) || (NumberSpiral == tribonachiSecond) || (NumberSpiral == tribonachiThird))
                {
                    result = true;
                    break;
                }
                if ((NumberSpiral == tribonachiCurrent) || (NumberSpiral == tribonachiFirst) || (NumberSpiral == tribonachiSecond) || (NumberSpiral == tribonachiSecond))
                {
                    result = true;
                    break;
                }
                else if (tribonachiCurrent < NumberSpiral)
                {
                    tribonachiCurrent = tribonachiFirst + tribonachiSecond + tribonachiThird;
                    tribonachiFirst = tribonachiSecond;
                    tribonachiSecond = tribonachiThird;
                    tribonachiThird = tribonachiCurrent;
                }
                else
                {
                    NumberSpiral += stepSpiral * spiralStepMul;
                    if (increasePower)
                    {
                        spiralStepMul++;
                    }
                    increasePower = !increasePower;
                }



            }
            if (result)
            {
                Console.WriteLine(NumberSpiral);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
