using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame.Scenes
{
    public class GameOverScene : BaseScene
    {
        public override void Render()
        {
            Console.WriteLine("▼▼▼▼▼▼ Game Over ▼▼▼▼▼▼");
        }
        public override void Update()
        {
            Util.Wait();
        }
        public override void Result()
        {
            Game.gameOver = true;
        }
    }
}
