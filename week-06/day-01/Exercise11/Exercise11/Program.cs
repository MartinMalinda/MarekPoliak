using System;
using System.Linq;
using System.IO;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            string contents = File.ReadAllText(@"text.txt");
            var splitted = contents.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            var words = splitted.Where(s => s.ToLower().All(c => (c > 96) && (c < 123)));
            var occurences = words.GroupBy(w => w);
            var orderedOccurences = occurences.OrderByDescending(w => w.Count());
            var topOccurences = orderedOccurences.Take(100);
            topOccurences.ToList().ForEach(s => Console.WriteLine(s.Key + " - " + s.Count()));
        }
    }
}
