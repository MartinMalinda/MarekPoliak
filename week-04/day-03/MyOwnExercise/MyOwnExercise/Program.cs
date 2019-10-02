using System;

namespace MyOwnExercise
{
    class Program
    {
        static public Random Ran { get; private set; } = new Random();
        static void Main(string[] args)
        {
            Flat myFlat = new Flat();
            for (int i = 0; i < 10; i++)
            {
                myFlat.People.Add(new Person());
            }
            myFlat.Pets.Add(new Pet());
            myFlat.Pets.Add(new Pet());
            myFlat.Info();
        }
    }
}
