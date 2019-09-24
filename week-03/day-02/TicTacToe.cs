using System;
using System.IO;


namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            Evaluate(@"./draw.txt");
        }

        public static void Evaluate(string path)
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
            for (int i = 0; i < contents.Length; i++)
            {
                if ((contents[i][0] == contents[i][1]) && (contents[i][0] == contents[i][2]))
                {
                    Console.WriteLine("win " + contents[i][0]);
                    return;
                }
            }
            for (int i = 0; i < contents.Length; i++)
            {
                if ((contents[0][i] == contents[1][i]) && (contents[0][i] == contents[2][i]))
                {
                    Console.WriteLine("win " + contents[0][i]);
                    return;
                }
            }
            if ((contents[0][0] == contents[1][1]) && (contents[0][0] == contents[2][2]))
            {
                Console.WriteLine("win " + contents[0][0]);
                return;
            }
            if ((contents[0][2] == contents[1][1]) && (contents[0][2] == contents[2][0]))
            {
                Console.WriteLine("win " + contents[0][2]);
                return;
            }
            Console.WriteLine("draw");

        }
    }
}