using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a double that is a distance in miles,
            // then it converts that value to kilometers and prints it

            //rick nad morty reference
            Console.WriteLine("show me what youve got!(miles :D) ");
            double miles = Convert.ToInt32(Console.ReadLine);
            Console.WriteLine(0.62*miles);
        }
    }
}