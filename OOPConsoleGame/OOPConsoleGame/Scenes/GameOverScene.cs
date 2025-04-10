namespace OOPConsoleGame.Scenes
{
    public class GameOverScene : BaseScene
    {
        public override void Render()
        {
            Util.PrintS("▼▼▼▼▼▼ Game Over ▼▼▼▼▼▼");
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
