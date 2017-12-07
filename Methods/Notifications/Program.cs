using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifications
{
    class Program
    {
        static string ShowSuccess(string operation, string massage)
        {
            string result = $"Successfully executed {operation}.\n==============================\nMessage: {massage}.";
            return result;
            
        }
        static string ShowError(string operation,int code)
        {
            string result = string.Empty;
            if(code>0)
            {
                result= $"Error: Failed to execute { operation}.\n==============================\nError Code: {code}.\nReason: Invalid Client Data.";
                return result;
            }
            else
            {
                
                result= $"Error: Failed to execute { operation}.\n==============================\nError Code: {code}.\nReason: Internal System Failure.";
                return result;
            }
            

        }
        static void Main(string[] args)
        {
            string result = string.Empty;

            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string value = Console.ReadLine();
                if(value=="success")
                {
                    string operation = Console.ReadLine();
                    string massage = Console.ReadLine();
                    result = ShowSuccess(operation, massage);
                    Console.WriteLine(result);
                    
                }
                else if(value=="error")
                {
                    string operation = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());
                    result= ShowError(operation, code);
                    Console.WriteLine(result);   
                }
                else
                {
                    continue;
                }
            }
            
            
        }
    }
}
