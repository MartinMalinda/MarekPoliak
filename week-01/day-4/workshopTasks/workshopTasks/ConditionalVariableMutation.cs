using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 24;
            int ou = 0;
            // if a is even increment out by one
            if (a % 2 = 0)
            {
                ou++;
            }

            Console.WriteLine(ou);

            int b = 13;
            string out2 = "";
            // if b is between 10 and 20 set out2 to "Sweet!"
            // if less than 10 set out2 to "Less!",
            // if more than 20 set out2 to "More!"
            if (b > 10 && b < 20)
            {
                out2 = "Sweet!";
            }

            Console.WriteLine(out2);

            int c = 123;
            int credits = 100;
            bool isBonus = false;
            // if credits are at least 50,
            // and isBonus is false decrement c by 2
            // if credits are smaller than 50,
            // and isBonus is false decrement c by 1
            // if isBonus is true c should remain the same
            if (credits => 50 && !isBonus)
            {
                c -= 2;
            } else if (credits < 50 && !isBonus)
            {
                c -= 1;
            } 

            Console.WriteLine(c);

            int d = 8;
            int time = 120;
            string out3 = "";
            // if d is dividable by 4
            // and time is not more than 200
            // set out3 to "check"
            // if time is more than 200
            // set out3 to "Time out"
            // otherwise set out3 to "Run Forest Run!"
            if (d % 4 == 0 && time <= 200)
            {
                out3 = "check";
            } else if (time > 200)
            {
                out3 = "time out";
            } else
            {
                out3 = "run forest ye ye just run";
            }

            Console.WriteLine(out3);
        }
    }
}