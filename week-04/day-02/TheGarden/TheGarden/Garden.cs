using System;
using System.Collections.Generic;
using System.Text;

namespace TheGarden
{
    class Garden
    {
        public List<Flower> Flowers { get; set; } = new List<Flower>();
        public List<Tree> Trees { get; set; } = new List<Tree>();

        public void Info()
        {
            foreach (var item in Flowers)
            {
                if (item.IsThirsty)
                {
                    Console.WriteLine(item.Color+" flower needs water");
                }
                else
                {
                    Console.WriteLine(item.Color + " flower doesnt need water");
                }
            }

            foreach (var item in Trees)
            {
                if (item.IsThirsty)
                {
                    Console.WriteLine(item.Color + " tree needs water");
                }
                else
                {
                    Console.WriteLine(item.Color + " tree doesnt need water");
                }
            }
        }
        public void WaterGarden(double water)
        {
            int sum = 0;
            foreach (var item in Flowers)
            {
                if (item.IsThirsty)
                {
                    sum++;
                }
            }
            foreach (var item in Trees)
            {
                if (item.IsThirsty)
                {
                    sum++;
                }
            }
            double amount = water / sum;
            for (int i = 0; i < Flowers.Count; i++)
            {
                if(Flowers[i].IsThirsty) Flowers[i].WaterMe(amount);
            }
            for (int i = 0; i < Trees.Count; i++)
            {
                if (Trees[i].IsThirsty) Trees[i].WaterMe(amount);
            }
        }
    }
}
