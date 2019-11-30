using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Wolf
    {
        public int MaxXp { get; set; }
        public int XP { get; set; }
        public int TimeOfLife { get; set; }

        public Wolf()
        {

        }
        public Wolf(int maxXp, int xp, int time)
        {
            this.MaxXp = maxXp;
            this.XP = xp;
            this.TimeOfLife = time;
        }

        public int Atack()
        {
            return -5;
        }
    }
}
