using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double sells = double.Parse(Console.ReadLine().ToLower());

            var comission = -1.0;

            if (city == "sofia")
            {
                if ((sells >= 0) && (sells <= 500))
                {
                    comission = 0.05;
                }
                else if ((sells > 500) && (sells <= 1000))
                {
                    comission = 0.07;
                }
                else if ((sells > 1000) && (sells <= 10000))
                {
                    comission = 0.08;
                }
                else if (sells > 10000)
                {
                    comission = 0.12;
                }
            }
            else if (city == "varna")
            {
                if ((sells >= 0) && (sells <= 500))
                {
                    comission = 0.045;
                }
                else if ((sells > 500) && (sells <= 1000))
                {
                    comission = 0.075;
                }
                else if ((sells > 1000) && (sells <= 10000))
                {
                    comission = 0.10;
                }
                else if (sells > 10000)
                {
                    comission = 0.13;
                }
            }
            else if (city == "plovdiv")
            {
                if ((sells >= 0) && (sells <= 500))
                {
                    comission = 0.055;
                }
                else if ((sells > 500) && (sells <= 1000))
                {
                    comission = 0.08;
                }
                else if ((sells > 1000) && (sells <= 10000))
                {
                    comission = 0.12;
                }
                else if (sells > 10000)
                {
                    comission = 0.145;
                }
            }
             
            if (comission>0)               
                {
                
                Console.WriteLine("{0:f2}", comission * sells  );
                }
            else
            {
                Console.WriteLine("error");
            }
            
            


        }
    }
}
