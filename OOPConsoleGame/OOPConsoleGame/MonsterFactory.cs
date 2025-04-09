using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame
{
    public class MonsterFactory
    {
        public Monster Create(string name)
        {
            switch (name)
            {
                case "고블린":
                    return new Monster("고블린", 1, 7, 7, 1, 1, 2);
            }
            return null;
        }
    }
}
