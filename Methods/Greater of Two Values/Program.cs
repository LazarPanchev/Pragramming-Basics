using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_of_Two_Values
{
    class Program
    {
        static int GetMax(int first, int second)
        {
            if(first>=second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static char GetMax(char first,char second)
        {
            if(first>=second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static string GetMax(string first,string second)
        {
            if(first.CompareTo(second)>=0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static void Main()
        {
            string type = Console.ReadLine();
            if(type=="int")
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                int result = GetMax(firstNum, secondNum);
                Console.WriteLine(result);
            }
            else if(type=="char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                char result = GetMax(firstChar, secondChar);
                Console.WriteLine(result);
            }
            else
            {
                string firstString = Console.ReadLine();
                string secondString= Console.ReadLine();
                string result = GetMax(firstString, secondString);
                Console.WriteLine(result);
            }
        }
    }
}
