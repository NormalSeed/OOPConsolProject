using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame.Objects
{
    public class MonsterTile : GameObject
    {
        private string name;

        public MonsterTile(string name, ConsoleColor color, char symbol, Position position)
            : base(color, symbol, position)
        {
            this.name = name;
        }
        public override void Interact(Player player)
        {
            Game.OverlapScene("Battle");
        }
    }
}
