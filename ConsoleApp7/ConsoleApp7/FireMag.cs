using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class FireMag : Mag
    {
        public int ManaFire { get; set; }
        public int TimeOfFire { get; set; }

        public FireMag(string name, int xp, int maxXp, bool isAlive, int mana, int time) : base(name, xp, maxXp, isAlive)
        {
            this.ManaFire = mana;
            this.TimeOfFire = time;
        }

        public override int Punch()
        {
            return -4;
        }

        public int FireBall()
        {
            Random rand = new Random();
            int h = rand.Next(1, 6);
            return h * this.TimeOfFire;
        }
    }
}
