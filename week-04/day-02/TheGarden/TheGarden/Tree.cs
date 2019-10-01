using System;
using System.Collections.Generic;
using System.Text;

namespace TheGarden
{
    class Tree : Herb
    {
        public Tree(string color, int water) : base(color, water)
        {
            if (water < 5)
            {
                IsThirsty = true;
            }
            else
            {
                IsThirsty = false;
            }
            Absorption = 0.4;
        }
    }
}
