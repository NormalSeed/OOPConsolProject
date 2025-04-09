using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame.Items
{
    public class Armor : IEquipable
    {
        public string Name { get; set; }
        public int Def { get; set; }
        public string type { get; set; }

        public Armor(string name, int def, string type, bool isEquipped = false)
        {
            Name = name;
            Def = def;
            this.type = type;
        }

        public void Equip()
        {
            Game.Player.def += Def;
        }

        public void Unequip()
        {
            Game.Player.def -= Def;
        }
    }
}
