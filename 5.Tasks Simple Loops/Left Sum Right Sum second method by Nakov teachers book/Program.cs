using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_Sum_Right_Sum_second_method_by_Nakov_teachers_book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            var n = int.Parse(Console.ReadLine());
            var leftSum = 0;
            var rightSum = 0;


            for(int i=0; i<n;i++)
            {
                leftSum = leftSum + int.Parse(Console.ReadLine());
            }
            for(int i=0; i<n; i++)
            {
                rightSum = rightSum + int.Parse(Console.ReadLine());
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}", leftSum);
            }
            else
            {
                var difference = Math.Abs(leftSum - rightSum);
                Console.WriteLine("No, diff = {0}", difference);
            }

        }
    }
}
