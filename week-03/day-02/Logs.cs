using System;
using System.IO;


namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] IPs = IP(@"./log.txt");
            for (int i = 0; i < IPs.Length; i++)
            {
                Console.WriteLine(IPs[i]);
            }
            Console.WriteLine("get to post ratio is: " + GetPostRatio(@"./log.txt"));
        }
        public static double GetPostRatio(string path)
        {
            string[] contents;
            try
            {
                contents = File.ReadAllLines(path);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return 0;
            }
            int get = 0;
            int post = 0;
            for (int lineIndex = 0; lineIndex < contents.Length; lineIndex++)
            {
                string word = new string("");
                for (int i = 41; i < 45; i++)
                {
                    word += contents[lineIndex][i];
                }
                if (word == "POST")
                {
                    post++;
                }
                else
                {
                    get++;
                }
            }
            return get / Convert.ToDouble(post);
        }
        public static string[] IP(string path)
        {
            string[] contents;
            try
            {
                contents = File.ReadAllLines(path);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return new string[0];
            }
            string[] IPs = new string[contents.Length];
            int IPsIndex = 0;
            bool isUnique;
            for (int lineIndex = 0; lineIndex < contents.Length; lineIndex++, IPsIndex++)
            {
                String line = new String("");
                isUnique = true;
                for (int i = 27; i < 38; i++)
                {
                    line += contents[lineIndex][i];
                }
                for (int i = 0; i <= IPsIndex; i++)
                {
                    if (IPs[i] == line)
                    {
                        IPsIndex--;
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    IPs[IPsIndex] = line;
                }
            }
            return IPs;
        }
    }
}