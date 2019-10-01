using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxExercise
{
    class Student : Person
    {
        private string previousOrganization;
        private int skippedDays;

        public Student(string name, int age, bool isMale, string previousOrganization) : base(name, age, isMale)
        {
            this.previousOrganization = previousOrganization;
            skippedDays = 0;
        }

        public Student() : base()
        {
            previousOrganization = "The School of Life";
            skippedDays = 0;
        }
            
    }
}
