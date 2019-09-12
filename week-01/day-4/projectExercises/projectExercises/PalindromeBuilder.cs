using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }


        static String createPalindrom(string input)
        {
            string result = input;
            for (int i = 0; i < input.length; i++)
            {
                result[input.Length + i] = input[input.Length - i - 1];
            }
            return result;
        }
    }
}