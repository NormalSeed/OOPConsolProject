using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame.Scenes
{
    public class UseScene : BaseScene
    {
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine($"{InventoryScene.chosenItem.Name}을/를 사용하시겠습니까?");
            Console.WriteLine();
            Console.WriteLine("1. 예");
            Console.WriteLine("2. 아니오");
        }

        public override void Update()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.Player.UseItem(InventoryScene.chosenItem.Name);
                    break;
            }
        }

        public override void Result()
        {
            switch(input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("아이템을 사용하였습니다.");
                    Util.Wait();
                    Game.PreviousScene();
                    break;
                case ConsoleKey.D2:
                    Game.PreviousScene();
                    break;
            }
        }
    }
}
