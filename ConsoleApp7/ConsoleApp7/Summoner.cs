using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Summoner : Mag
    {
        public int ManaCall { get; set; }
        public int TimeOfAlive { get; set; }

        public Summoner(string name, int xp, int maxXp, bool isAlive, int mana, int time) : base(name, xp, maxXp, isAlive)
        {
            this.ManaCall = mana;
            this.TimeOfAlive = time;
        }

        public override int Punch()
        {
            return -5;
        }

        public Wolf CallWolf()
        {
            Random random = new Random();
            int d = random.Next(30, 50);
            Wolf w1 = new Wolf(d, d, this.TimeOfAlive);
            return w1;

        }
    }
}
