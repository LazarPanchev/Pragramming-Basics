using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOSPITAL
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int treatedPatients = 0;
            int untreatedPatients = 0;
            int countOfDoctors = 7;

            for (int day = 1; day <=period; day++)
            {
                var currentPatients= int.Parse(Console.ReadLine());
                if((day%3==0) && (untreatedPatients>treatedPatients))
                {
                    countOfDoctors++;
                }
                if(currentPatients>countOfDoctors)
                {
                    treatedPatients += countOfDoctors;
                    untreatedPatients += currentPatients - countOfDoctors;
                }
                else
                {
                    treatedPatients += currentPatients;
                }

            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");


        }
    }
}
