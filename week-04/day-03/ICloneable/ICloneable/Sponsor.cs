using System;
using System.Collections.Generic;
using System.Text;

namespace ICloneable
{
    class Sponsor : Person
    {
        private string company;

        private int hiredStudents;

        public Sponsor(string name, int age, bool isMale, string company) : base(name, age, isMale)
        {
            hiredStudents = 0;
            this.company = company;
        }

        public Sponsor() : base()
        {
            company = "Google";
            hiredStudents = 0;
        }

        public void Introduce()
        {
            //yadi yada i already know this stuff
            Console.WriteLine("introducement of a sponsor");
        }

        public void Hire()
        {
            hiredStudents++;
        }

        public void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }
    }
}
