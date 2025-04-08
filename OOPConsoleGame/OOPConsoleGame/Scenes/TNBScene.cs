using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame.Scenes
{
    internal abstract class TNBScene
    {
        protected ConsoleKey input;
        public abstract void Render();
        public abstract void Choice();
        public void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public abstract void Result();
        public abstract void Wait();
        public abstract void Next();
        public void OpenInven()
        {

        }
    }
}
