using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame.Items
{
    public class Potion : IUsable
    {
        public string Name { get; set; }
        public int HealAmount { get; set; }
        public Potion(string name, int healAmount)
        {
            this.Name = name;
            this.HealAmount = healAmount;
        }
        public void Use()
        {
            Game.Player.curHp += HealAmount;
            if (Game.Player.curHp > Game.Player.maxHp)
            {
                Game.Player.curHp = Game.Player.maxHp;
            }
        }
    }
}
