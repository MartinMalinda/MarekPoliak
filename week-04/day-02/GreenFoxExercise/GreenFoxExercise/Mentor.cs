using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxExercise
{
    class Mentor:Person
    {
        public level Level { get; set; }

        public Mentor(string name, int age, bool isMale,level level) : base(name, age, isMale)
        {
            Level = level;
        }
        
        public Mentor() : base()
        {
            Level = level.intermediate;
        }

        public void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }

        public void Introduce()
        {
            Console.WriteLine("Hi, I'm "+Name+Age+Level); //whatever
        }
    }
    enum level
    {
        junior,
        intermediate,
        senior
    }
}
