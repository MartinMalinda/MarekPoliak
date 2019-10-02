using System;
using System.Collections.Generic;
using System.Text;

namespace MyOwnExercise
{
    class Person:ICreature
    {
        public string Name { get; private set; } 
        public int Age { get; private set; }
        public genders Gender { get; private set; }

        public Person()
        {
            int numOfNames = Enum.GetValues(typeof(names)).Length;
            int ranEnumIndex = Program.Ran.Next(0, numOfNames);
            Name = ((names)ranEnumIndex).ToString();
            Age = Program.Ran.Next(0, 100);
            int numOfGenders = Enum.GetValues(typeof(genders)).Length;
            ranEnumIndex= Program.Ran.Next(0, numOfGenders);
            Gender = (genders)ranEnumIndex;
        }

        public Person(string name, int age, genders gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
    }
}
