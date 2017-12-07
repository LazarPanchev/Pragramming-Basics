using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello__Name_
{
    class Program
    {
        static string Name(string name)
        {
            string newValue = "Hello, " + name + "!";
            return newValue;
        }
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string result = Name(name);
            Console.WriteLine(result);
        }
    }
}
