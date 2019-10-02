using System;
using System.Collections.Generic;
using System.Text;

namespace MyOwnExercise
{
    class Flat : IThing
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public List<ICreature> People { get; set; }
        public List<ICreature> Pets { get; set; }
        public int Area { get; private set; }

        public Flat()
        {
            People = new List<ICreature>();
            Pets = new List<ICreature>();
            Area = 50;
        }

        public Flat(List<ICreature> people, List<ICreature> pets, int area)
        {
            People = people;
            Pets = pets;
            Area = area;
        }

        public void Info()
        {
            Console.WriteLine("flat has "+Area+" squaredmeters");
            foreach (var item in People)
            {
                Console.WriteLine("Person "+item.Name+" lives here:");
                item.Introduce();
            }
            foreach (var item in Pets)
            {
                Console.WriteLine("Pet "+item.Name + " lives here:");
                item.Introduce();
            }
        }
    }
}
