using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame.Objects
{
    public class Place : GameObject
    {
        private string scene;

        public Place(string scene, ConsoleColor color, char symbol, Position position)
            : base(color, symbol, position)
        {
            this.scene = scene;
        }

        public override void Interact(Player player)
        {
            Game.ChangeScene(scene);
        }
    }
}
