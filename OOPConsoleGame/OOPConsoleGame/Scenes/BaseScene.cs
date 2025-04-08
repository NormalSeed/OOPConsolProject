using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame.Scenes
{
    public abstract class TNBScene
    {
        protected ConsoleKey input;
        public abstract void Render();
        public void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public abstract void Update();
        public abstract void Result();
        public void OpenInven()
        {

        }
    }
}
