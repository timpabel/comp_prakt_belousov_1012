using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_1
{
    internal class Les_4
    {
        static public int ex_13(int[] arr, int targ)
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
        static public string ex_11(int a, int b)
        {

            int x = 0;
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Уравнение имеет бесконечное количество решений.");
                    return "many solution";
                }
                else
                {
                    Console.WriteLine("Уравнение не имеет решений.");
                    return "no solution";
                }
            }
            else
            {
                x = b / a;
                if (b % a != 0)
                {
                    Console.WriteLine("Уравнение не имеет целочисленных решений.");
                    return "no solution";
                }
                else
                {
                    Console.WriteLine($"Решение уравнения {a}x = {b}: x = {x}");
                    return x.ToString();
                }
            }




        }
        //test metod dlya ex_11
        public static void test_ex_11()
        {
            if (ex_11(1, -2).Equals ("-2"))
                Console.WriteLine("verno1");
            else
                Console.WriteLine("error1");
            if (ex_11(2, -1).Equals ("no solution"))
                Console.WriteLine("verno2");
            else
                Console.WriteLine("error2");
            if (ex_11(0,0).Equals("many solution" ))
                Console.WriteLine("verno3");
            else
                Console.WriteLine("error3");
            if (ex_11(5,0).Equals("0") )
                Console.WriteLine("verno4");
            else
                Console.WriteLine("error4");
            if (ex_11(0,7).Equals("no solution"))
                Console.WriteLine("verno5");
            else
                Console.WriteLine("error5");
            if (ex_11(10, 11).Equals("no solution"))
                Console.WriteLine("verno6");
            else
                Console.WriteLine("error6");
            if (ex_11(1,30000).Equals("30000"))
                Console.WriteLine("verno6");
            else
                Console.WriteLine("error6");
            if (ex_11(-15000, 15000).Equals("-1"))
                Console.WriteLine("verno7");
            else
                Console.WriteLine("error7");
            if (ex_11(-29999, 24999).Equals("no solution"))
                Console.WriteLine("verno8");
            else
                Console.WriteLine("error8");

        }
        public static int ex_14(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        } 
        public static void test_ex_14()
        {
            if (ex_14(123) == 6)
                Console.WriteLine("verno1");
            else
                Console.WriteLine("erorr1");
            if (ex_14(0) == 0)
                Console.WriteLine("verno2");
            else
                Console.WriteLine("error2");
            if (ex_14(106) == 7)
                Console.WriteLine("verno3");
            else
                Console.WriteLine("error3");
        }
        public static int ex_15(int[] num)
        {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > 0 && num[i] % 2 == 0)
                {
                    sum += num[i];
                    count++;
                }
            }
            return sum / count;
        }
        public static void test_ex_15()
        {

        }


    }
       
}
