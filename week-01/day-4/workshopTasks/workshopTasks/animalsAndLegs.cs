
using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have

            int chickens = Convert.ToInt32(Console.ReadLine);
            int  pigs = Convert.ToInt32(Console.ReadLine);
            Console.WriteLine(chickens*2+pigs*4);
        }
    }
}