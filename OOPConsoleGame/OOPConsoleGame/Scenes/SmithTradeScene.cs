using OOPConsoleGame.Items;

namespace OOPConsoleGame.Scenes
{
    public class SmithTradeScene : BaseScene
    {

        public override void Render()
        {
            Game.Player.ItemAdded += OnItemAdded;
            Console.WriteLine("카르타의 장비를 구매하시겠습니까?");
            Console.WriteLine();
            Console.WriteLine("1. 예");
            Console.WriteLine("2. 아니오");
        }

        public override void Update()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.Player.AddEInventory(new Item("단단한 철검", 1));
                    Game.Player.AddEInventory(new Item("질긴 가죽갑옷", 1));
                    Game.Player.inventory[0].Quantity -= 200;
                    Util.Wait();
                    break;
            }
        }

        public override void Result()
        {
            Game.Player.ItemAdded -= OnItemAdded;
            //1번 누르면 구매 후 광장으로
            //2번 누르면 대장간씬으로
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("Town");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Smithery");
                    break;
            }
        }

        private void OnItemAdded(string name)
        {
            Console.WriteLine($"{name}을/를 손에 넣었다!");
        }
    }
}
