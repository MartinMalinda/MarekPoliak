using System;
using System.Linq;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var squaredPositive = n.Where(num => num > 0).Select(num => num * num);
            foreach (var item in squaredPositive)
            {
                Console.WriteLine(item);
            }
        }
    }
}
