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
            int index = Game.Player.inventory.FindIndex(item => item.Name == Name);
            if (Game.Player.inventory[index].Quantity > 0)
            {
                Game.Player.curHp += HealAmount;
                if (Game.Player.curHp > Game.Player.maxHp)
                {
                    Game.Player.curHp = Game.Player.maxHp;
                }
                Game.Player.inventory[index].Quantity -= 1;
            }
            else
            {
                Console.WriteLine("더이상 존재하지 않습니다.");
            }
        }
    }
}
