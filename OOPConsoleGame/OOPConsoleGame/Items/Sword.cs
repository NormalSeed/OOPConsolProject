using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame.Items
{
    public class Sword : IEquipable
    {
        string Name { get; set; }
        int Atk { get; set; }
        string type { get; set; }
        bool IsEquipped { get; set; }
        public Sword(string name, int atk, string type, bool isEquipped = false)
        {
            Name = name;
            Atk = atk;
            this.type = type;
            IsEquipped = isEquipped;
        }

        public void Equip()
        {
            Game.OverlapScene("Equip");
            //Game.Player.equipments.Add(Name, this);
            //Game.Player.atk += Atk;
        }

        public void Unequip()
        {
            //Game.Player.equipments.Remove(Name);
            //Game.Player.atk -= Atk;
        }
    }
}
