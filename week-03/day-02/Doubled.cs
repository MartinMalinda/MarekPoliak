using System;
using System.IO;


namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            Decrypt(@"./zen.txt");

        }
        public static void Decrypt(string path)
        {
            try
            {
                string[] contents = File.ReadAllLines(path);
                string[] contents2 = new string[contents.Length];
                for (int lineIndex = 0; lineIndex < contents.Length; lineIndex++)
                {
                    for (int characterIndex = 0; characterIndex < contents[lineIndex].Length; characterIndex += 2)
                    {
                        contents2[lineIndex] += contents[lineIndex][characterIndex];
                    }
                }
                File.WriteAllLines(path, contents2);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
            }
        }
    }
}