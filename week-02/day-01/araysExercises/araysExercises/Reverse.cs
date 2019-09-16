using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`
            int[] aj = { 3, 4, 5, 6, 7 };
            int temp;
            for (int i = 0; i < aj.Length / 2; i++)
            {
                temp = aj[i];
                aj[i] = aj[aj.Length - i - 1];
                aj[aj.Length - i - 1] = temp;
            }
            for (int i = 0; i < aj.Length; i++)
            {
                Console.WriteLine(aj[i]);
            }
            Console.ReadLine();
        }
    }
}