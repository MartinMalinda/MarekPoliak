using System;
using System.IO;

namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Divide(0));
        }

        public static int Divide(int divider)
        {
            try
            {
                return 10 / divider;
            }
            catch (DivideByZeroException e)
            {
                return -1;
            }
        }
    }
}