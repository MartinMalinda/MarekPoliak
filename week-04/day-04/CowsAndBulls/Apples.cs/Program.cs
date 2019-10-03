using System;
using System.Collections.Generic;

namespace CowsAndBull
{
    class Program
    {
        static void Main(string[] args)
        {
            var guesser = new CowsAndBulls();
            Console.WriteLine(guesser.CountBulls("1234","1231"));
            /*Console.WriteLine(guesser.Goal);
            do
            {
                int input;
                input=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(guesser.Guess(input));
            } while (!guesser.IsFinished); */
            
        }
    }

    public class CowsAndBulls
    {
        public string Goal { get; private set; } = new Random().Next(1000, 10000).ToString();
        public bool IsFinished { get; private set; } = false;
        public int Counts { get; private set; } = 0;

        public int CountBulls(string goal, string input)
        {
            int num = 0;
            for (int i = 0; i < 4; i++)
            {
                if (goal[i] == input[i])
                {
                    continue;
                }
                for (int j = 0; j < 4; j++)
                {
                    if (goal[j] == input[i])
                    {
                        num++;
                    }
                }
            }
            return num;
        }

        public int CountCows(string input)
        {
            int num = 0;

            for (int i = 0; i < 4; i++)
            {
                if (Goal[i] == input[i])
                {
                    num++;
                }
            }
            return num;
        }

        public string Guess(int num)
        {
            string output = String.Empty;
            if (num > 9999 || num<1000)
            {
                return "bad input";
            }
            string input = num.ToString();
            int cows = CountCows(input);
            int bulls = CountBulls(Goal,input);
            if (cows == 4)
            {
                IsFinished = true;
            }
            output=(cows+" cows and "+bulls+" bulls");
            return output;
        }
    }
}