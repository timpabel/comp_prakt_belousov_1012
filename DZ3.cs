using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class DZ3
    {
        public static double ex_15(int[] ar)
        {
            double count = 0; double sum = 0;

            for(int i = 0;i < ar.Length; i++)
            {
                if (ar[i] >0 && ar[i] % 2 == 0)
                {
                    sum += ar[i];
                    count++;
                }
            }
            //Console.WriteLine(sum / count);
            return count == 0 ? 0.0 : sum / count;
        }
        public static void test_ex_15()
        {
            if (ex_15(new int[] { 2, 4, 6 }) == 4.0) Console.WriteLine("ok1");
            else Console.WriteLine("eorror1");

            if (ex_15(new int[] { 1,3,5 }) == 0.0) Console.WriteLine("ok2");
            else Console.WriteLine("eorror2");

            if (ex_15(new int[] { 1,2,3,4,5,6,2,0 }) == 3.5) Console.WriteLine("ok3");
            else Console.WriteLine("eorror3");

            if (ex_15(new int[] {  }) == 0.0) Console.WriteLine("ok4");
            else Console.WriteLine("eorror4");

            if (ex_15(new int[] { 2 }) == 2.0) Console.WriteLine("ok5");
            else Console.WriteLine("eorror5");
        }
        public static int ex_16(int a, int b)
        {
            while (b != 0)
            {
                int q = b;
                b = a % b;
                a = q;
            }
            return a;
        }
        public static void test_ex_16()
        {
            if (ex_16(8, 20) == 4) Console.WriteLine("ok1");
            else Console.WriteLine("eorror1");

            if (ex_16(5, 0) == 5) Console.WriteLine("ok2");
            else Console.WriteLine("eorror2");

            if (ex_16(0, 0) == 0) Console.WriteLine("ok3");
            else Console.WriteLine("eorror3");

            if (ex_16(-18, -12) == -6) Console.WriteLine("ok4");
            else Console.WriteLine("eorror4");

            if (ex_16(7, 19) == 1) Console.WriteLine("ok5");
            else Console.WriteLine("eorror5");

            if (ex_16(1071, 462) == 21) Console.WriteLine("ok6");
            else Console.WriteLine("eorror6");

            if (ex_16(-8, 36) == 4) Console.WriteLine("ok7");
            else Console.WriteLine("eorror7");
        }
        static public  string ex_17(int[]ar)
        {
            string result = "";
            for (int i = 1; i < ar.Length - 1; i++)
            {
                if (ar[i] == ar[i - 1] + ar[i + 1]) result += $"{ar[i]} ";
            }
            

            return result;

        }
        static public void test_ex_17()
        {
            if (ex_17(new int[] { 1, 2, 1, 3, 5, 2 }).Equals("2 5 ")) Console.WriteLine("ok1");
            else Console.WriteLine("eorror1");

            if (ex_17(new int[] {  }).Equals("")) Console.WriteLine("ok2");
            else Console.WriteLine("eorror2");

            if (ex_17(new int[] { 1,2,3,4,5}).Equals("")) Console.WriteLine("ok3");
            else Console.WriteLine("eorror3");

            if (ex_17(new int[] { 1 }).Equals("")) Console.WriteLine("ok4");
            else Console.WriteLine("eorror4");
        }
    }

}
