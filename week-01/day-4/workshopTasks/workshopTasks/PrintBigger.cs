using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2)
            {
                Console.WriteLine(number1);
            } else if (number2 > number1)
            {
                Console.WriteLine(number2);
            } else
            {
                Console.WriteLine("none is bigger");
            }
                  
        }
    }
}