
using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000
            Console.WriteLine("give me 3 sides of a cuboid");
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Surface Area: {0}", a * b * 2 + a * c * 2 + b * c * 2);
            Console.WriteLine("Volume: {0}", a * b * c);

        }
    }
}