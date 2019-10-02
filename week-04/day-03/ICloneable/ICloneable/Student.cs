using System;
using System.Collections.Generic;
using System.Text;

namespace ICloneable
{

    class Student : Person, ICloneable<Student>
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

        public Student Clone()
        {
            return this;
        }

    }
}
