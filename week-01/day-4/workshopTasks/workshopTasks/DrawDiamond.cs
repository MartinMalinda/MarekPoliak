using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //
            // The diamond should have as many lines as the number was

            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                for (int k = num; k > i + 1; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i * 2 - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            num--;
            for (int i = num - 1; i > 0; i--)
            {
                for (int k = num; k >= i + 1; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i * 2 - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}