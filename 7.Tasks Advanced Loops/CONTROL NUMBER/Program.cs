using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROL_NUMBER
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int controlNum = int.Parse(Console.ReadLine());
            var sum = 0;
            var counter = 0;
            bool yes = false;    

            for (int i = 1; i <=N; i++)
            {
                if (yes)
                    break;
                for (int j = M; j >=1; j--)
                {
                    if (yes)
                        break;
                    sum += i * 2 + j * 3;
                    counter++;
                    if(sum>=controlNum)
                    {
                        yes = true;
                        
                    }
                }
            }
            if(yes)
            {
                Console.WriteLine("{0} moves", counter );
                Console.WriteLine("Score: {0} >= {1}", sum, controlNum);
            }
            else
            {
                Console.WriteLine("{0} moves", counter);
            }


        }
    }
}
