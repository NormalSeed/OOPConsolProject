using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame.Scenes
{
    public class EquipScene : BaseScene
    {
        public override void Render()
        {
            Console.WriteLine($"{EInventoryScene.chosenItem.Name}을/를 장착하시겠습니까?");
            Console.WriteLine();
            Console.WriteLine("1. 예");
            Console.WriteLine("2. 아니오");
        }

        public override void Update()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.Player.EquipItem(EInventoryScene.chosenItem.type, EInventoryScene.chosenItem);
                    break;
            }
        }

        public override void Result()
        {
            Game.PreviousScene();
        }
    }
}
