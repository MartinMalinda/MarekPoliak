using System;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var evenNums = n.Where(num => num % 2 == 0);
            evenNums = from num in n
                       where num % 2 == 0
                       select num;
        }
    }
}
