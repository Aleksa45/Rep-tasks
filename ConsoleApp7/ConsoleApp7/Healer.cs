using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Healer : Mag
    {
        public int ManaXp { get; set; }
        public Healer(string name, int xp, int maxXp, bool isAlive, int mana) : base(name, xp, maxXp, isAlive)
        {
            this.ManaXp = mana;
        }
        public override int Punch()
        {
            return -2;
        }

        public Mag Hill(Mag m1)
        {
            m1.XP = m1.MaxXp;
            return m1;
        }

        public Mag Alive(Mag m1)
        {
            m1.XP = m1.MaxXp;
            m1.IsAlive = true;
            return m1;
        }

        public Wolf Hill(Wolf w1)
        {
            w1.XP = w1.MaxXp;
            return w1;
        }
    }
}
