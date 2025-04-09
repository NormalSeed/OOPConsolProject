﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame.Items
{
    public interface IEquipable
    {
        string Name { get; set; }
        int Atk { get; set; }
        string type { get; set; }
        bool IsEquipped { get; set; }
        public void Equip();
        public void Unequip();
    }
}
