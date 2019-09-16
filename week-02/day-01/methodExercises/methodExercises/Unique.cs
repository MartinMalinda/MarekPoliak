using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a method that takes an array of integers as a parameter
            //  Returns an array of integers where every integer occurs only once

            //  Example
            //Console.WriteLine(Unique(new[] { 1, 11, 34, 11, 52, 61, 1, 34 }));
            //  should print: `[1, 11, 34, 52, 61]`
            int[] arr = Unique(new[] { 1, 11, 34, 11, 52, 61, 1, 34 });
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static int findMax(int[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        public static int[] Unique(int[] arr)
        {

            bool[] check = new bool[findMax(arr)];
            int uniqueNums = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (!check[arr[i] - 1])
                {
                    uniqueNums++;
                    check[arr[i] - 1] = true;
                }
            }
            int[] result = new int[uniqueNums];
            int j = 0;
            for (int i = 0; i < check.Length; i++)
            {
                if (check[i])
                {
                    result[j] = i + 1;
                    j++;
                }
            }
            return result;
        }
    }
}