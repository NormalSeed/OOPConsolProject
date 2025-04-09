using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleGame.Items;

namespace OOPConsoleGame.Scenes
{
    public class InventoryScene : BaseScene
    {
        private int page = 1;
        public static IUsable chosenItem;

        public override void Render()
        {
            Console.Clear();
            //한 페이지에 5개씩 인벤토리의 물건을 보여주고
            //6번째 줄에는 소지 골드(G)
            //그 다음 줄에는 페이지수를 표시
            if (Game.Player.inventory.Count > 1)
            {
                for (int i = 1; i < Game.Player.inventory.Count; i++)
                {
                    int index = i % 5;
                    if (Game.Player.inventory[i] != null)
                    {
                        Console.WriteLine($"{index}. {Game.Player.inventory[index + (page - 1) * 5].Name} " +
                            $": {Game.Player.inventory[index + (page - 1) * 5].Quantity}개");
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.SetCursorPosition(0, 5);
            Console.WriteLine($"{Game.Player.inventory[0].Quantity} G");
            Console.WriteLine($"{page} 페이지");
            Console.WriteLine("[결정] : 번호    [뒤로가기] : ESC");
        }

        public override void Update()
        {
            switch(input)
            {
                case ConsoleKey.RightArrow:
                    if (Game.Player.inventory.Count > page * 5)
                    { 
                        page += 1;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (page > 2)
                    {
                        page -= 1;
                    }
                    break;
                case ConsoleKey.D1:
                    if (Game.Player.inventory.Count > 1)
                    {
                        chosenItem = Game.usableDic[Game.Player.inventory[1 + (page - 1) * 5].Name];
                    }
                    break;
                case ConsoleKey.D2:
                    if (Game.Player.inventory.Count > 2)
                    {
                        chosenItem = Game.usableDic[Game.Player.inventory[2 + (page - 1) * 5].Name];
                    }
                    break;
                case ConsoleKey.D3:
                    if (Game.Player.inventory.Count > 3)
                    {
                        chosenItem = Game.usableDic[Game.Player.inventory[3 + (page - 1) * 5].Name];
                    }
                    break;
                case ConsoleKey.D4:
                    if (Game.Player.inventory.Count > 4)
                    {
                        chosenItem = Game.usableDic[Game.Player.inventory[4 + (page - 1) * 5].Name];
                    }
                    break;
                case ConsoleKey.D5:
                    if (Game.Player.inventory.Count > 5)
                    {
                        chosenItem = Game.usableDic[Game.Player.inventory[5 + (page - 1) * 5].Name];
                    }
                    break;
            }
        }

        public override void Result()
        {
            switch(input)
            {
                case ConsoleKey.Escape:
                    Game.PreviousScene();
                    break;

            }
        }
    }
}
