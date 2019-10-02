﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyOwnExercise
{
    class Pet : Animal, ICreature
    {
        public Pet(string name, int age, genders gender, animals animalType) : base(name, age, gender, animalType) { }

        public Pet() : base() { }

        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine("And im friendly "+AnimalType.ToString());
        }

        public override void Speak()
        {
            Console.WriteLine("Pet me!");
        }
    }
}
