using System;
using System.Collections.Generic;
using System.Text;

namespace ICloneable
{
    class Mentor : Person
    {
        private level level;

        public Mentor(string name, int age, bool isMale, level level) : base(name, age, isMale)
        {
            this.level = level;
        }

        public Mentor() : base()
        {
            level = level.intermediate;
        }

        public void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }

        public void Introduce()
        {
            Console.WriteLine("Hi, I'm " + name + age + level); //whatever
        }
    }
    enum level
    {
        junior,
        intermediate,
        senior
    }
}
