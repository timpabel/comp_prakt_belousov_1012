using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program1
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("наименьший делитель = "+i);
                    break;
                }
            }
        }
    }
}
