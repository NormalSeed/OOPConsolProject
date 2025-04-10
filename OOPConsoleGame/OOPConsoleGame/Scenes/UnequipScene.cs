namespace OOPConsoleGame.Scenes
{
    public class UnequipScene : BaseScene
    {
        public override void Render()
        {
            Console.WriteLine("장비를 해제하시겠습니까?");
            Console.WriteLine("1. 예");
            Console.WriteLine("2. 아니오");
            Console.WriteLine();
        }

        public override void Update()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.Player.UnequipItem(EquipStatScene.chosenItem.type);
                    break;
            }
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("장비가 해제되었습니다.");
                    Util.Wait();
                    Game.PreviousScene();
                    break;
                case ConsoleKey.D2:
                    Util.Wait();
                    Game.PreviousScene();
                    break;
            }
        }
    }
}
