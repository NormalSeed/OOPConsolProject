namespace OOPConsoleGame.Scenes
{
    public class TitleScene : BaseScene
    {
        public override void Render()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("*   OOP  Mini RPG   *");
            Console.WriteLine("*********************");
            Console.WriteLine();
            Console.WriteLine("계속하려면 아무 키나 눌러주세요.");
        }

        public override void Update()
        {

        }

        public override void Result()
        {
            Game.ChangeScene("Intro");
        }
    }
}
