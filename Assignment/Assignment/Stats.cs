using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal static class Stats
    {
        public static void Mean()
        {
            
            
                int[] arr = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };
            int sum = 0, median = 0;
            decimal m = 0;
            
            //mean
            foreach (int x in arr)
                {
                sum = sum + x;
            }
            m = (decimal)sum / arr.Length;
            Console.WriteLine($"Mean:{m}");

            // median
            median = (arr.Length) / 2;
            Console.WriteLine($"Median :{arr[median]}");


            //mode
            int maxcount = 0, maxnum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 1; j < arr.Length - 1; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count > maxcount)
                {
                    maxcount = count;
                    maxnum = arr[i];
                }
            }
            Console.WriteLine($"Mode : {maxnum}");
        }
    }
}
