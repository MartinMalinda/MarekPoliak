using System;
using System.Collections.Generic;
namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a number and an array of integers as a parameter
            //  Returns the indices of the integers in the array of which the first number is a part of
            //  Or returns an empty array if the number is not part of any of the integers in the array

            //  Example:
            //Console.WriteLine(SubInt(1, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: `[0, 1, 4]`
            //Console.WriteLine(SubInt(9, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: '[]'

            int[] arr = SubInt(1, new int[] { 1, 11, 34, 52, 61, 1010 });
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static int[] SubInt(int num, int[] arr)
        {
            List<int> results = new List<int>();
            int divider;
            for (int i = 0; i < arr.Length; i++)
            {
                divider = 10;
                if (arr[i] != 0)
                {
                    while (arr[i] > 0)
                    {
                        if (arr[i] % divider == num)
                        {
                            results.Add(i);
                            break;

                        }
                        arr[i] = arr[i] / divider;
                        divider *= 10;
                    }
                }
                else
                {
                    if (arr[i] == num)
                    {
                        results.Add(i);
                    }
                }
            }
            int[] result = new int[results.Count];
            for (int i = 0; i < results.Count; i++)
            {
                result[i] = results[i];
            }
            return result;
        }
    }
}