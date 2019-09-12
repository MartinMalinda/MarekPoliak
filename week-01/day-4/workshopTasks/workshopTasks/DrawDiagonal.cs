using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %%  %
            // % % %
            // %  %%
            // %%%%%
            //
            // The square should have as many lines as the number was

            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.Write("%");
            }
            Console.WriteLine();

            for (int i = 0; i < num - 2; i++)
            {
                Console.Write("%");
                for (int j = 0; j < num - 2; j++)
                {
                    if (j == i)
                    {
                        Console.Write("%");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("%");
                Console.WriteLine();
            }

            for (int i = 0; i < num; i++)
            {
                Console.Write("%");
            }

        }
    }
}