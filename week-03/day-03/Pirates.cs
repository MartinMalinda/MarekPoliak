using System;
using System.Collections.Generic;

namespace Pirates
{
    class Program
    {
        public static void Main()
        {
            Armada army1 = new Armada(10);
            Armada army2 = new Armada(10);
            if (army1.War(army2))
            {
                Console.WriteLine("army1 has won");
            }
            else
            {
                Console.WriteLine("army2 has won");
            }
        }
    }
    public class Armada
    {
        public List<Ship> Ships { get; set; } = new List<Ship>();
        public Armada(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Ships.Add(new Ship());
                Ships[i].FillShip();
            }
        }
        public bool War(Armada otherArmy)
        {
            int myArmyI = 0;
            int otherArmyI = 0;
            while (this.Ships.Count - 1 != myArmyI && otherArmy.Ships.Count - 1 != otherArmyI)
            {
                if (this.Ships[myArmyI].BattleUntilDeath(otherArmy.Ships[otherArmyI]))
                {
                    Console.WriteLine();
                    otherArmyI++;
                }
                else
                {
                    Console.WriteLine();
                    myArmyI++;
                }
            }
            if (this.Ships.Count - 1 == myArmyI)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
    public class Ship
    {
        public List<Pirate> Crew { get; set; } = new List<Pirate>();
        public Pirate Captain { get; set; }
        public int AlivePirates { get; set; } = 0;
        public bool IsDestroyed { get; set; } = false;
        public void FillShip()
        {
            Captain = new Pirate();
            for (int i = 0; i < new Random().Next(1, 21); i++)
            {
                Crew.Add(new Pirate());
            }
            CountAlivePirates();
        }
        public void Info()
        {
            CountAlivePirates();
            Console.WriteLine("number of alive pirates" + AlivePirates);
            Console.WriteLine("captain drank " + Captain.GlassesPoured + " glasses");
        }
        public void CountAlivePirates()
        {
            IsDestroyed = false;
            AlivePirates = 0;
            for (int i = 0; i < Crew.Count; i++)
            {
                if (!(Crew[i].IsDead))
                {
                    AlivePirates++;
                }
            }
        }
        public void Kill(int num, Ship ship)
        {
            if (ship.IsDestroyed)
            {
                return;
            }
            for (int i = ship.AlivePirates - 1; ((i >= ship.AlivePirates - num) && (i >= 0)); i--)
            {
                ship.Crew[i].IsDead = true;
            }
            ship.CountAlivePirates();
            if (ship.AlivePirates == 0)
            {
                ship.IsDestroyed = true;
            }
        }
        public bool Battle(Ship otherShip)
        {
            if ((this.AlivePirates - this.Captain.GlassesPoured) > (otherShip.AlivePirates - otherShip.Captain.GlassesPoured))
            {
                Party(this);
                otherShip.Kill(new Random().Next(1, otherShip.AlivePirates + 1), otherShip);
                return true;
            }
            else if ((this.AlivePirates - this.Captain.GlassesPoured) < (otherShip.AlivePirates - otherShip.Captain.GlassesPoured))
            {
                Party(otherShip);
                this.Kill(new Random().Next(1, this.AlivePirates + 1), this);
                return false;
            }
            else
            {
                Party(this);
                Party(otherShip);
                return Battle(otherShip);
            }
        }
        public bool BattleUntilDeath(Ship otherShip)
        {
            bool result;
            this.Info();
            otherShip.Info();
            do
            {
                result = Battle(otherShip);
                if (result)
                {
                    Console.WriteLine("ship1 won");
                }
                else
                {
                    Console.WriteLine("ship2 won");
                }
                this.Info();
                otherShip.Info();
            } while ((this.AlivePirates != 0) && (otherShip.AlivePirates != 0));
            return result;
        }
        public void Party(Ship ship)
        {
            for (int i = 0; i < new Random().Next(1, 5); i++)
            {
                ship.Captain.DrinkSomeRum();
            }
        }
    }
    public class Pirate
    {
        public int GlassesPoured { get; set; } = 0;
        public bool IsDead { get; set; } = false;
        public void DrinkSomeRum()
        {
            if (IsDead)
            {
                Console.WriteLine("hes dead");
                return;
            }
            GlassesPoured++;
        }
        public void HowsItGoingMate()
        {
            if (IsDead)
            {
                Console.WriteLine("hes dead");
                return;
            }
            if (GlassesPoured < 5)
            {
                Console.WriteLine("Pour me anudder!");
            }
            else
            {
                Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
            }
        }
        public void Die()
        {
            IsDead = true;
        }
        public void Brawl(Pirate anotherPirate)
        {
            if (this.IsDead || anotherPirate.IsDead)
            {
                Console.WriteLine("cant brawl with a dead man");
                return;
            }
            switch (new Random().Next(1, 4))
            {
                case 1:
                    this.IsDead = true;
                    break;
                case 2:
                    anotherPirate.IsDead = true;
                    break;
                case 3:
                    Console.WriteLine("draw");
                    break;
            }
        }
    }
}