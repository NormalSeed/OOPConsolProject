using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame.Scenes
{
    public class EquipStatScene : BaseScene
    {
        public override void Render()
        {
            Console.Clear();
            Game.Player.ShowEquipments();
            Console.WriteLine();
            Console.WriteLine("[뒤로가기] : ESC");
        }

        public override void Update()
        {
            
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.Escape:
                    Game.PreviousScene();
                    break;
            }
        }
    }
}
