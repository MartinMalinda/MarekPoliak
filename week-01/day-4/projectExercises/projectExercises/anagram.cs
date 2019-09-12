using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }


        static bool isAnagram(string str1, string str2)
        {
            if (str1.Length != str2.Length) { return false; }
            int j = str1.Length;
            for (int i = 0; i < j; i++)
            {
                if (str1[i] != str2[j])
                {
                    return false;
                }
            }
            
            return true;
        }
    }
}