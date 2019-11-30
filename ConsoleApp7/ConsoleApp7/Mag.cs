using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Mag
    {
        public string Name { get; set; }
        public int XP { get; set; }
        public int MaxXp { get; set; }
        public bool IsAlive { get; set; }
        public Mag()
        {

        }
        public Mag(string name, int xp, int maxXp, bool isAlive)
        {
            this.Name = name;
            this.XP = xp;
            this.MaxXp = maxXp;
            this.IsAlive = isAlive;
        }

        public virtual int Punch()
        {
            return -3;
        }
    }
}
