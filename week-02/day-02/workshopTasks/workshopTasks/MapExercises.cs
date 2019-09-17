
using System.Collections.Generic;
using System;

namespace MapExercises
{
    public class MapExercises
    {
        public static void Main(string[] args)
        {
            Dictionary<int, char> map = new Dictionary<int, char>();
            if (map.Count == 0)
            {
                Console.WriteLine("its empty");
            }
            else
            {
                Console.WriteLine("its not empty");
            }
            map.Add(97, 'a');
            map.Add(98, 'b');
            map.Add(99, 'c');
            map.Add(65, 'A');
            map.Add(66, 'B');
            map.Add(67, 'C');
            foreach (var item in map)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
            map.Add(68, 'D');
            Console.WriteLine(map.GetValueOrDefault(99));
            map.Remove(97);
            if (map.ContainsKey(100))
            {
                Console.WriteLine("value with key 100 is in the dictionary");

            }
            else
            {
                Console.WriteLine("its not there");
            }
            map.Clear();


            Dictionary<string, string> strMap = new Dictionary<string, string>()
            {
                {"978-1-60309-452-8" , "A Letter to Jo"},
                {"978-1-60309-459-7" , "Lupus"},
                {"978-1-60309-444-3" , "Red Panda and Moon Bear"},
                {"978-1-60309-461-0", "The Lab" }
            };
            foreach (var item in strMap)
            {
                Console.WriteLine(item.Value + " (" + item.Key + ")");
            }
            strMap.Remove("978-1-60309-444-3");
            foreach (var item in strMap)
            {
                if (item.Value == "The Lab")
                {
                    strMap.Remove(item.Key);
                    break;
                }
            }
            strMap.Add("978-1-60309-450-4", "They Called Us Enemy");
            strMap.Add("978-1-60309-453-5", "Why Did We Trust Him");
            if (strMap.ContainsValue("478-0-61159-424-8"))
            {
                Console.WriteLine("contains");
            }
            else
            {
                Console.WriteLine("doesnt");
            }
            Console.WriteLine(strMap.GetValueOrDefault("978-1-60309-453-5"));
        }
    }
}