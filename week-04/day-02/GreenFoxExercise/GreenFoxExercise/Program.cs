using System;
using System.Collections.Generic;

namespace GreenFoxExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();

            var mark = new Person("Mark", 46, true);
            people.Add(mark);
            var jane = new Person();
            people.Add(jane);
            var john = new Student("John Doe", 20, true, "BME");
            people.Add(john);
            var student =
                new Student();
            people.Add(student);
            var gandhi = new Mentor("Gandhi", 148, true, level.senior);
            people.Add(gandhi);
            var mentor = new Mentor();
            people.Add(mentor);
            var sponsor = new Sponsor();
            people.Add(sponsor);
            var elon = new Sponsor("Elon Musk", 46, true, "SpaceX");
            people.Add(elon);

            

            for (int i = 0; i < 5; i++)
            {
                elon.Hire();
            }

            for (int i = 0; i < 3; i++)
            {
                sponsor.Hire();
            }

            foreach (var person in people)
            {
                person.Introduce();
                person.GetGoal();
            }

            Cohort awesome = new Cohort("AWESOME");
            awesome.AddStudent(student);
            awesome.AddStudent(john);
            awesome.AddMentor(mentor);
            awesome.AddMentor(gandhi);
            awesome.Info();

        }
    }
}
