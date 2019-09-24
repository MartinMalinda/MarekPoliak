using System;
using System.IO;
using System.Collections.Generic;

namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(MostBirths(@"./Births.txt"));
        }
        public static int MostBirths(string path)
        {
            string[] contents;
            try
            {
                contents = File.ReadAllLines(path);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return -1;
            }
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < contents.Length; i++)
            {
                string substr = contents[i].Substring(contents[i].IndexOf(";") + 1, 4);

                int year = Convert.ToInt32(substr);
                if (map.ContainsKey(year))
                {
                    map[year]++;
                }
                else
                {
                    map.Add(year, 1);
                }
            }
            int max = 0;
            foreach (var item in map)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                }
            }
            foreach (var item in map)
            {
                if (item.Value == max)
                {
                    return item.Key;
                }
            }
            return -1;
        }

    }
}