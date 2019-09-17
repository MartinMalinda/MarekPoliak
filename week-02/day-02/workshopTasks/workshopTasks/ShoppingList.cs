using System;
using System.Collections.Generic;

namespace ShoppingList
{
    class ShoppingList
    {
        public static void main()
        {
            List<string> list = new List<string>("Eggs", "milk", "fish", "apples", "bread", "chicken");
        }
        public static bool check(string str, List<string> list)
        {
            return list.Contains(str);
        }
    }
}