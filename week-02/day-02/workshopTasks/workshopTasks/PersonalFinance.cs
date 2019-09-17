using System;
using System.Collections.Generic;

namespace PesonalFinance
{
    class PersonalFinance
    {
        public static void Main()
        {
            List<int> list = new List<int>(500, 1000, 1250, 175, 800, 120);
            
        }
        public static int spent(List<int> list)
        {
            int sum = 0;
            foreach (var item in list)
            {
                sum += item;
            }
            return sum;
        }
        public static int largest(List<int> list)
        {
            int max = 0;
            foreach (var item in list)
            {
                if (max < item)
                {
                    max = item;
                }
            }
            return max;
        }
        public static int smallest(List<int> list)
        {
            int min = list[0];
            foreach (var item in list)
            {
                if (min > item)
                {
                    min = item;
                }
            }
            return min;

        }
        public static double average(List<int> list)
        {
            return spent(list) / list.Count;
        }
    }
}