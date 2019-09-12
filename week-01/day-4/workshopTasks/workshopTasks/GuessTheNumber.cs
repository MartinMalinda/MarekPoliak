using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8

            int num = 24;
            int usersNum;
            do
            {
                usersNum = Convert.ToInt32(Console.ReadLine());
                if (usersNum > num)
                {
                    Console.WriteLine("The stored number is smaller");
                }
                else if (usersNum < num)
                {
                    Console.WriteLine("The stored number is greater");
                }
                else
                {
                    Console.WriteLine("You found the number: " + num);
                    return;
                }
            } while (true);
        }
    }
}