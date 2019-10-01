using System;
using System.Collections.Generic;
using System.Text;

namespace TheGarden
{
    class Herb
    {
        public string Color { get; set; }
        public double Water { get; set; }
        public double Absorption { get; set; }
        public bool IsThirsty {
            get { if (Water < 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set { }
        }

        public Herb(string color,int water)
        {
            Color = color;
            Water = water;
        }
        
        public void WaterMe(double water)
        {
            Water = water*Absorption;
        }
    }
}
