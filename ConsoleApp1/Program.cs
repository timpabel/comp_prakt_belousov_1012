using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                int maxLen = 0; 
                int currentLen = 1; 

                int previousNumber = int.Parse(Console.ReadLine());

                

                while (previousNumber != 0)
                {
                    int currentNumber = int.Parse(Console.ReadLine());

                    if (currentNumber == previousNumber)
                    {
                        currentLen++;
                    }
                    else
                    {
                        if (currentLen > maxLen)
                        {
                            maxLen = currentLen;
                        }
                        currentLen = 1;
                    }

                    previousNumber = currentNumber;
                }

                if (currentLen > maxLen)
                {
                    maxLen = currentLen;
                }

                Console.WriteLine("наибольшее число подряд идущих элементов = " + maxLen);
            }
      
        }
    }
}
