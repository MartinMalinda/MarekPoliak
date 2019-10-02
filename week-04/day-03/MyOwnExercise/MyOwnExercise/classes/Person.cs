using System;
using System.Collections.Generic;
using System.Text;

namespace MyOwnExercise
{
    class Person : ICreature, IMoveable
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public string Name { get; private set; } 
        public int Age { get; private set; }
        public int Weight { get; set; }
        public int posX { get; set; }
        public int posY { get; set; }
        public genders Gender { get; private set; }

        public Person()
        {
            int numOfGenders = Enum.GetValues(typeof(genders)).Length;
            int ranEnumIndex = Program.Ran.Next(0, numOfGenders);
            Gender = (genders)ranEnumIndex;
            if (Gender == genders.female)
            {
                int numOfNames = Enum.GetValues(typeof(femaleNames)).Length;
                ranEnumIndex = Program.Ran.Next(0, numOfNames);
                Name = ((femaleNames)ranEnumIndex).ToString();
            }
            else
            {
                int numOfNames = Enum.GetValues(typeof(maleNames)).Length;
                ranEnumIndex = Program.Ran.Next(0, numOfNames);
                Name = ((maleNames)ranEnumIndex).ToString();
            }
            Age = Program.Ran.Next(0, 100);
        }

        public Person(string name, int age, genders gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public void Poop()
        {
            Console.WriteLine("I Pooped");
        }

        public void Drink()
        {
            Console.WriteLine("I Drank");
        }

        public void Eat()
        {
            Console.WriteLine("I Ate");
        }

        public void Introduce()
        {
            Console.WriteLine("hi im "+Name+" and im "+Gender.ToString());
        }

        public void Move()
        {
            Console.WriteLine("I moved");
        }
    }
}
