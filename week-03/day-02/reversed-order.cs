using System;
using System.IO;


namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            Decrypt(@"./reversed-order.txt");
        }
        public static void Decrypt(string path)
        {
            try
            {
                string[] contents = File.ReadAllLines(path);
                string[] contents2 = new string[contents.Length];
                for (int lineIndex = contents.Length - 1; lineIndex >= 0; lineIndex--)
                {
                    for (int characterIndex = 0; characterIndex < contents[lineIndex].Length; characterIndex++)
                    {
                        contents2[contents.Length - lineIndex - 1] += contents[lineIndex][characterIndex];
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