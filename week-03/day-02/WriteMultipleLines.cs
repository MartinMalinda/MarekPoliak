using System;
using System.IO;


namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {


        }
        public static void WriteNameIntoFile(string path, string word, int count)
        {
            try
            {
                for (int i = 0; i < count; i++)
                {

                }
                File.AppendAllText(path, word);
            }
            catch
            {
                Console.WriteLine("i cant write the file but im not raising errors");
            }
            return;
        }
    }
}