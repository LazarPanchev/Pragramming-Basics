using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ON_TIME_FOR_THE_EXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHours = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHours = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            string late = "Late";
            string Ontime = "On time";
            string early = "Early";

            int examTime = (examHours * 60) + examMinutes;
            int arrivalTime = (arrivalHours * 60) + arrivalMinutes;
            int totalMinutesDifference = arrivalTime - examTime;

            //int hour =Math.Abs(minutesDifference / 60);
            //int minutes = Math.Abs(minutesDifference % 60);

            string studentArrival = late;
            if (totalMinutesDifference < -30)
            {
                studentArrival = early;
            }
            else if(totalMinutesDifference<=30)
            {
                studentArrival = Ontime;
            }

            string results = string.Empty;
            if (totalMinutesDifference != 0)
            {
                int hoursDifference = Math.Abs(totalMinutesDifference / 60);
                int minutesDifference = Math.Abs(totalMinutesDifference % 60);

                if (hoursDifference > 0)
                    results = string.Format("{0}:{1:00} hours", hoursDifference, minutesDifference);
                else
                {
                    results = minutesDifference + "minutes";

                }
                if(totalMinutesDifference<0)
                {
                    results += " before the start";
                }
                else
                {
                    results += " after the start";
                }
                Console.WriteLine(studentArrival);
                if(!string.IsNullOrEmpty(results))
                {
                    Console.WriteLine(results);
                }
            }
            
        }
}   }
