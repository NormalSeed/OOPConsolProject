namespace OOPConsoleGame.Scenes
{
    public class StatusScene : BaseScene
    {
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("플레이어 스테이터스");
            Game.Player.ShowStatus();
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
