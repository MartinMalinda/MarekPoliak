using System;

namespace ChangeElement
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `s`
            //   with the following content: `[1, 2, 3, 8, 5, 6]`
            // - Change the 8 to 4
            // - Print the fourth element
            int[] S = { 1, 2, 3, 8, 5, 6 };
            S[3] = 4;
            Console.WriteLine(S[3]);

            Console.ReadLine();
        }
    }
}