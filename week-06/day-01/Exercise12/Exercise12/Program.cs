using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            string contents = File.ReadAllText(@"text.txt");
            var characters = contents.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> chars = characters.ToList();
            List<List<string>> characterInfo = new List<List<string>>();
            characters.Skip(1).ToList().ForEach(c => {
                characterInfo.Add(c.Split(';', StringSplitOptions.RemoveEmptyEntries).ToList());
            });
            var knownMassChars = characterInfo.Where(c => c[2] != "unknown");
            Console.WriteLine(knownMassChars.ToList().Find(v=>Convert.ToDouble(v[2])==knownMassChars.Max(c => Convert.ToDouble(c[2])))[0]);
            Console.WriteLine(characterInfo.Where(c => c[7] == "male").Where(c=>c[1]!="unknown").Average(c=>Convert.ToDouble(c[1])));
            Console.WriteLine(characterInfo.Where(c => c[7] == "female").Where(c => c[1] != "unknown").Average(c => Convert.ToDouble(c[1])));
            Dictionary<string, Dictionary<string, int>> result = new Dictionary<string, Dictionary<string, int>>();

            var genderGrouped = characterInfo.GroupBy(s => s[7] != "male" && s[7] != "female" ? "other" : s[7]);
            genderGrouped.ToList().ForEach(g =>
            {
                Console.WriteLine(g.Key);
                g.GroupBy(a => Grouper(a[6])).ToList().ForEach(q => Console.WriteLine(q.Key + " " + q.Count()));
            });
        }

        public static string Grouper(string age)
        {
            if (age == "unknown")
            {
                return age + ":";
            }
            else if (Convert.ToInt32(new String(age.TakeWhile(ch => ch > 47 && ch < 58).ToArray())) > 40)
            {
                return "above 40:";
            }
            else if (Convert.ToInt32(new String(age.TakeWhile(ch => ch > 48 && ch < 58).ToArray())) < 21)
            {
                return "below 21:";
            }
            else
            {
                return "between 21 and 40:";
            }
        }
    }
}
