using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4

            int num = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[num];
            double sum = 0;
            for (int i = 0; i < num; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
                sum += nums[i];
            }
            Console.WriteLine("Sum: {0}, Average: {1}", sum, sum / num);
        }
    }
}