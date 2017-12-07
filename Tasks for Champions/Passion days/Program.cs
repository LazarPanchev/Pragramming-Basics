using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passion_days
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal shopingMoney = decimal.Parse(Console.ReadLine());
            int purchases = 0;
            string command= Console.ReadLine();
            while(command != "mall.Enter")
            {
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while (command != "mall.Exit")
                {
                    foreach (char action in command)
                    {
                        if ((action >= 'A') && (action <= 'Z'))
                        {
                            decimal price = action-(action * 0.5m);
                            if (shopingMoney < price)
                            {
                                continue;
                            }
                            shopingMoney -= price;
                            purchases++;
                        }
                        else if ((action >= 'a') && (action <= 'z'))
                        {
                            decimal price = action-(action * 0.7m);
                            if (shopingMoney <price)
                            {
                                continue;
                            }
                            shopingMoney -= price;
                            purchases++;
                        }
                        else if (action == '%')
                        {
                            decimal price = shopingMoney / 2;
                            if (shopingMoney <=price)
                            {
                                continue;
                            }
                            shopingMoney -= price;
                            purchases++;
                        }
                        else if (action == '*')
                        {
                            shopingMoney += 10m;
                        }
                        else
                        {
                            decimal price = action;
                            if (shopingMoney <price)
                            {
                                continue;
                            }
                            shopingMoney -= price;
                            purchases++;
                        }

                    }
                command = Console.ReadLine();

            }
            
            if (purchases==0)
            {
                Console.WriteLine("No purchases. Money left: {0:f2} lv.",shopingMoney);
            }
            else
            {
                Console.WriteLine("{0} purchases. Money left: {1:f2} lv.",purchases,shopingMoney);

            }

        }
    }
}
