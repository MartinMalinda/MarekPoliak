using System;
using System.Collections.Generic;


namespace projectExercisesSecondDay
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> ls = palindromeSearcher("dog goat dad duck doodle never");
            for (int i = 0; i < ls.Count; i++)
            {
                Console.WriteLine(ls[i]);
            }
        }

        static bool isAnagram(string str1, string str2)
        {
            if (str1.Length != str2.Length) { return false; }
            int j = 0;
            for (int i = 0; i <= str1.Length - 1; i++)
            {
                if (str1[i] != str2[j])
                {
                    return false;
                }
                j++;
            }
            return true;
        }
        static List<String> palindromeSearcher(string input)
        {
            List<String> output = new List<String>();
            if (input.Length < 3)
            {
                return output;
            }
            for (int i = 0; i < input.Length - 2; i++)
            {
                for (int j = i; j < input.Length - 2; j++)
                {
                    String str1 = new String("");
                    String str2 = new String("");
                    for (int k = i; k < Convert.ToInt32(Math.Floor((input.Length - j) / 2.0)) + i; k++)
                    {
                        str1 += input[k];
                    }
                    for (int k = input.Length - j - 1 + i; k >= Convert.ToInt32(Math.Ceiling((input.Length - j) / 2.0)) + i; k--)
                    {
                        str2 += input[k];
                    }
                    if (isAnagram(str1, str2))
                    {
                        if ((input.Length - j) % 2 == 1)
                        {
                            str1 += input[(input.Length - j) / 2 + i];
                        }
                        String str3 = new String("");
                        for (int o = 0; o < str2.Length; o++)
                        {
                            str3 += str2[str2.Length - o - 1];
                        }
                        output.Add(str1 + str3);
                    }
               }
            }
            return output;
        }
    }
}