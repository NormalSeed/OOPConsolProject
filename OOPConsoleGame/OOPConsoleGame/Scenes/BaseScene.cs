namespace OOPConsoleGame.Scenes
{
    public abstract class BaseScene
    {
        protected ConsoleKey input;
        public abstract void Render();
        public void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public abstract void Update();
        public abstract void Result();
    }
}
