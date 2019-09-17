using System.Collections.Generic;
using System;

namespace ListExercise
{
    public class ListExercise
    {
        public static void Main(string[] args)
        {
            List<string> names = new List<string>();
            Console.WriteLine(names.Count);
            names.Add("William");
            if (names.Count == 0)
            {
                Console.WriteLine("list is empty");
            }
            else
            {
                Console.WriteLine("list is not empty");
            }
            names.Add("John");
            names.Add("Amanda");
            Console.WriteLine(names.Count);
            Console.WriteLine(names[2]);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + names[i]);
            }
            names.RemoveAt(1);
            for (int i = names.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }
            names.Clear();



            List<string> ListA = new List<string>(new string[5] { "Apple", "Avocado", "Blueberries", "Durian", "Lychee" });
            List<string> ListB = new List<string>(ListA);
            if (ListA.Contains("Durian"))
            {
                Console.WriteLine("it does contain");
            }
            else
            {
                Console.WriteLine("it does not contain");
            }
            ListB.Remove("Durian");
            ListA.Insert(4, "Kiwifruit");
            Console.WriteLine(ListA.Count);
            Console.WriteLine(ListB.Count);
            ListA.IndexOf("Avocado");
            ListB.IndexOf("Durian");
            ListB.Add("Passion Fruit and Pomelo");
            Console.WriteLine(ListA[2]);


        }
    }
}