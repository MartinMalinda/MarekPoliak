using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function called `sum` that returns the sum of numbers from zero to the given parameter

        }
        public static int sum(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}