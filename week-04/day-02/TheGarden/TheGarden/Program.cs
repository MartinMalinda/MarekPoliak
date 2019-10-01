using System;

namespace TheGarden
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden myGarden = new Garden();
            myGarden.Trees.Add(new Tree("purple", 0));
            myGarden.Trees.Add(new Tree("orange", 0));
            myGarden.Flowers.Add(new Flower("black", 0));
            myGarden.Flowers.Add(new Flower("white", 0));

            myGarden.Info();

            myGarden.WaterGarden(40);
            myGarden.Info();

            myGarden.WaterGarden(70);
            myGarden.Info();
        }
    }
}
