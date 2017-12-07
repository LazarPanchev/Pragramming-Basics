using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Repeater
{
    class Program
    {
        static string RepeatString(string words,int repeatTimes)
        {
            string result = string.Empty;
            for (int i = 0; i < repeatTimes; i++)
            {
                result += words;
            }
            return result;
        }
        static void Main()
        {
            string word = Console.ReadLine();
            int repeatTimes = int.Parse(Console.ReadLine());
            string result = RepeatString(word, repeatTimes);
            Console.WriteLine(result);
        }
    }
}
