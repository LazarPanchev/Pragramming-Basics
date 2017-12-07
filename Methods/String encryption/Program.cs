using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_encryption
{
    class Program
    {
        static string Encrypt(char letter)
        {

            string totalModify = string.Empty;
            var askiiCode = (int)letter;
            var firstDigit = askiiCode;
            while (firstDigit>=10)
            {
                firstDigit = firstDigit / 10;
            }
            var lastDigit = askiiCode % 10;
            string cryptNum = firstDigit.ToString() +lastDigit.ToString();
            var cryptNumModifiedInChar = askiiCode + lastDigit;
            var firstmodifyChar = (char)cryptNumModifiedInChar;
            var lastmodifyChar = ((char)(askiiCode - firstDigit));
            totalModify = firstmodifyChar + cryptNum + lastmodifyChar;
            return totalModify;


        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string cryptSubString = string.Empty;
            string cryptString = string.Empty;
            for (int i = 0; i <N; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                cryptSubString=Encrypt(symbol);
                cryptString += cryptSubString;

            }
            Console.WriteLine(cryptString);
        }
    }
}
