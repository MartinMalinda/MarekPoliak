﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyOwnExercise
{
    class WildAnimal : Animal, ICreature
    {
        public WildAnimal(string name, int age, genders gender, animals animalType) : base(name, age, gender, animalType) { }

        public WildAnimal() : base() { }

        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine("And im wild " + AnimalType.ToString());
        }

        public override void Speak()
        {
            Console.WriteLine("Go Away!");
        }
    }
}
