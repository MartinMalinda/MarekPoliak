using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4
            int[] numbers = new int[5];
            for(int i = 0; i < 5; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine);
            }
            int sum = 0;
            
            for (int i = 0; i < 5; i++)
            {
                sum += numbers[i];
            }
            int average = sum / 5;
            Console.WriteLine("sum: " + sum + " and average: " + average);
        }
    }
}