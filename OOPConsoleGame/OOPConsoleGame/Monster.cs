using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame
{
    public class Monster
    {
        public string name;
        public int level;
        public int maxHp;
        public int hp;
        public int atk;
        public int def;
        public int spd;

        public Monster(string name, int level, int maxHp, int hp, int atk, int def, int spd)
        {
            this.name = name;
            this.level = level;
            this.maxHp = maxHp;
            this.hp = hp;
            this.atk = atk;
            this.def = def;
            this.spd = spd;
        }
    }
}
