using System;
using System.Collections.Generic;
using System.Text;

namespace MyOwnExercise
{
    abstract class Animal : ICreature
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public genders Gender { get; private set; }

        public animals AnimalType { get; private set; }

        protected Animal(string name, int age, genders gender, animals animalType)
        {
            Name = name;
            Age = age;
            Gender = gender;
            AnimalType = animalType;
        }

        protected Animal()
        {
            int numOfNames = Enum.GetValues(typeof(names)).Length;
            int ranEnumIndex = Program.Ran.Next(0, numOfNames);
            Name = ((names)ranEnumIndex).ToString();
            Age = Program.Ran.Next(0, 20);
            int numOfGenders = Enum.GetValues(typeof(genders)).Length;
            ranEnumIndex = Program.Ran.Next(0, numOfGenders);
            Gender = (genders)ranEnumIndex;
            int numOfAnimals = Enum.GetValues(typeof(animals)).Length;
            ranEnumIndex = Program.Ran.Next(0, numOfAnimals);
            AnimalType = (animals)ranEnumIndex;
        }

        public void Poop()
        {
            Console.WriteLine("I pooped");
        }

        public void Eat()
        {
            Console.WriteLine("I ate");
        }

        public void Drink()
        {
            Console.WriteLine("I drank");
        }

        public virtual void Introduce()
        {
            Console.WriteLine("Im an animal - "+AnimalType.ToString());
        }

        public abstract void Speak();
    }
}
