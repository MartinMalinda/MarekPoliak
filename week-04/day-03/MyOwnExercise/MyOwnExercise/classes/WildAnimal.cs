using System;
using System.Collections.Generic;
using System.Text;

namespace MyOwnExercise
{
    class WildAnimal : Animal, ICreature, IMoveable
    {
        public WildAnimal(string name, int age, genders gender, animals animalType) : base(name, age, gender, animalType) { }

        public WildAnimal() : base() { }

        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine("And im wild " + AnimalType.ToString()+" because im wild animal; my name is "+Name);
        }

        public override void Speak()
        {
            Console.WriteLine("Go Away!");
        }
    }
}
