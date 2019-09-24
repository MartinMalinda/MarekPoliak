using System;
using System.IO;

namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"my-file.txt";

            try
            {
                string[] content = File.ReadAllLines(path);
                for (int i = 0; i < content.Length; i++)
                {
                    Console.WriteLine(content[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Unable to read file: my-file.txt");
            }

        }
    }
}