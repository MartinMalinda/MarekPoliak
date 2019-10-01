using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxExercise
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public bool IsMale { get; set; }

        public Person(string name,int age, bool isMale)
        {
            Name = name;
            Age = age;
            IsMale = isMale;
            Console.ReadLine();
        }
        public Person()
        {
            Name = "JaneDoe";
            Age = 30;
            IsMale = false;
        }
        
        public void Introduce()
        {
            Console.WriteLine("Hi...whatever :D"+Name+Age+IsMale);
        }
        public void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
    }
}
