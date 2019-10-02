using System;
using System.Collections.Generic;
using System.Text;

namespace MyOwnExercise
{
    abstract class Furniture : IThing, IWeighable, IMoveable
    {
        public int Weight { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }

        public void Move()
        {
            Console.WriteLine("I moved");
        }
    }
}
