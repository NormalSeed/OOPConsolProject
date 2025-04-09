using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame.Items
{
    public interface IEquipable
    {
        string Name { get; set; }
        string type { get; set; }
        public void Equip();
        public void Unequip();
    }
}
