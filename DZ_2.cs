using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  static class DZ_2
    {
        static public int ex_14(int[] arr)
        {
            int mn = 10000000;
            int flag = 0;
            for (int i=1;i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    flag = 1;
                    if (arr[i]< mn)
                    {
                        mn = arr[i];
                    }
                }
            }
            if (flag == 1)
            {
                Console.WriteLine($"наименьшее нечётное число {mn}");
            }
            else
            {
                Console.WriteLine(0);
            }
            return 0;
        }
        static public int ex_13(int[]arr, int targ)
        {
            int index = BinarySearch(arr, targ);

            if (index != -1)
            {
                Console.WriteLine($"Значение {targ} найдено на индексе: {index}");
            }
            else
            {
                Console.WriteLine("NO");
            }
            return 0;

        }
        static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                {
                    return mid; 
                }
                else if (array[mid] < target)
                {
                    left = mid + 1; 
                }
                else
                {
                    right = mid - 1; 
                }
            }

            return -1; 
        }
        static public int ex_11(int a, int b)
        {
            int x = 0;
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Уравнение имеет бесконечное количество решений.");
                }
                else
                {
                    Console.WriteLine("Уравнение не имеет решений.");
                }
            }
            else
            {
                x = b / a;
                if (b % a != 0)
                {
                    Console.WriteLine("Уравнение не имеет целочисленных решений.");
                }
                else
                {
                    Console.WriteLine($"Решение уравнения {a}x = {b}: x = {x}");
                }
            }
            return 0;

        }
    }
}
