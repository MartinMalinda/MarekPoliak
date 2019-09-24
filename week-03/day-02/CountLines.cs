using System;
using System.IO;
using System.Linq;

namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            File.WriteAllText("whatever.txt", "whatever");
            Console.WriteLine(CountLines(@"whatever.txt"));
        }
        public static int CountLines(string path)
        {
            try
            {
                return File.ReadLines(path).Count();
            }
            catch
            {
                return 0;
            }
        }
    }
}