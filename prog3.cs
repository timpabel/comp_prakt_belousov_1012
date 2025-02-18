using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class prog3
    {
        static void Main(string[] args)
            {
                string num = Console.ReadLine();
                char firstDigit = num[0];

                bool flag = true;
                foreach (char digit in num)
                {
                    if (digit != firstDigit)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    Console.WriteLine("Да");
                }
                else
                {
                    Console.WriteLine("Нет");
                }
            }
        }
    }
 
