using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba_greshka_11
{
    class Program
    {
        static void Main(string[] args)
        {

            int steps = int.Parse(Console.ReadLine());  // Vurti rezultati bez da gi sumira a pribavq to4ki v zavisimost ot dadeni usloviq
            // ili pribavq to4ki ili to4kite sa polovinata ot prednata interaciq to4ki. Deistviq s edna suma.
            var result = 0.0;
            var sum = 0.0;
            var num09 = 0.00;
            var num1019 = 0.00;
            var num2029 = 0.00;
            var num3039 = 0.00;
            var num4050 = 0.00;
            var other = 0.00;
            var currentSum = 0.00;
            for (int i = 0; i < steps; i++)
            {
                double n = double.Parse(Console.ReadLine());
                if ((n >= 0) && (n <= 9))
                {
                    result = currentSum + (0.20 * n);  //vurti se edin i su6t rezultat bez da se sumira po uslovie i po obqsnenie v zadachata
                    num09++;
                }
                else if ((n >= 10) && (n <= 19))
                {
                    result = currentSum + (0.30 * n);  // rezultata e rezultata ot prednata interaciq samo ne ot sumata ot vsi4ki
                    num1019++;
                }
                else if ((n >= 20) && (n <= 29))
                {
                    result = currentSum + (0.40 * n);
                    num2029++;
                }
                else if ((n >= 30) && (n <= 39))
                {
                    result = currentSum + 50;
                    num3039++;
                }
                else if ((n >= 40) && (n <= 50))
                {
                    result = currentSum + 100;
                    num4050++;
                }
                else
                {
                    result = currentSum / 2;
                    other++;
                }
                currentSum = result; // zapazva rezultata samo za interaciqta bez da go sumira


            }
            Console.WriteLine("{0:f2}", currentSum);
            Console.WriteLine("From 0 to 9: {0:f2}%", (num09 / steps) * 100);
            Console.WriteLine("From 10 to 19: {0:f2}%", (num1019 / steps) * 100);
            Console.WriteLine("From 20 to 29: {0:f2}%", (num2029 / steps) * 100);
            Console.WriteLine("From 30 to 39: {0:f2}%", (num3039 / steps) * 100);
            Console.WriteLine("From 40 to 50: {0:f2}%", (num4050 / steps) * 100);
            Console.WriteLine("Invalid numbers: {0:f2}%", (other / steps) * 100);





        }
    }
}
