using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleGame.Items;

namespace OOPConsoleGame.Objects
{
    public class PickableItem : GameObject
    {
        private Item item;

        public PickableItem(Item item, ConsoleColor color, char symbol, Position position)
            : base(color, symbol, position)
        {
            this.item = item;
        }
        public override void Interact(Player player)
        {
            player.inventory.Add(item);
        }
    }
}
