using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //n mi e kolko cifri imam vutre. po uslovie trqbva da e 2
            int sum1 = 0;
            int sum2 = 0;
            
            for (int i=0;i<n;i++) //purvi cikul- - za sumirane-zavisi ot n
            {
               
                int number = int.Parse(Console.ReadLine());
                sum1 += number;
            }
            
            for (int i = 0; i < n; i++) //vtori cikul- - za sumirane-zavisi ot n
            {
                int number = int.Parse(Console.ReadLine());
                sum2 += number;

            }
            int diff = Math.Abs(sum1 - sum2);
            if (sum1==sum2)
            {
                Console.WriteLine("Yes, sum = {0}", sum1);
            }
            else
                Console.WriteLine("No, diff = {0}", diff);

        }
    }
}
