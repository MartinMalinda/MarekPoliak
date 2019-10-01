using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxExercise
{
    class Person
    {
        protected string name;

        protected int age;

        protected bool isMale;

        public Person(string name,int age, bool isMale)
        {
            this.name = name;
            this.age = age;
            this.isMale = isMale;
        }
        public Person()
        {
            name = "JaneDoe";
            age = 30;
            isMale = false;
        }
        
        public void Introduce()
        {
            Console.WriteLine("Hi...whatever :D"+name+age+isMale);
        }
        public void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
    }
}
