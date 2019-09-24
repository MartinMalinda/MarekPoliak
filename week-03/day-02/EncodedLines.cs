using System;
using System.IO;
using System.Collections.Generic;

namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            decode(@"./encoded-lines.txt");
        }
        public static void decode(string path)
        {
            string[] contents;
            try
            {
                contents = File.ReadAllLines(path);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return;
            }
            string[] contents2 = new string[contents.Length];
            for (int i = 0; i < contents.Length; i++)
            {
                for (int j = 0; j < contents[i].Length; j++)
                {
                    if (contents[i][j] == ' ')
                    {
                        contents2[i] += " ";
                    }
                    else
                    {
                        contents2[i] += Convert.ToChar(contents[i][j] - 1);
                    }

                }
            }
            File.WriteAllLines(path, contents2);
        }
    }
}