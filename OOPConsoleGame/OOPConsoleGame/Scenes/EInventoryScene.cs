using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleGame.Items;

namespace OOPConsoleGame.Scenes
{
    public class EInventoryScene : BaseScene
    {
        private int page = 1;
        public static IEquipable chosenItem;
        public override void Render()
        {
            Console.Clear();

            if (Game.Player.eInventory.Count >= 1)
            {
                for (int i = 0; i < Game.Player.eInventory.Count; i++)
                {
                    int index = i % 5;
                    if (Game.Player.eInventory[i] != null)
                    {
                        Console.WriteLine($"{index + 1}. {Game.Player.eInventory[index + (page - 1) * 5].Name} " +
                            $": {Game.Player.eInventory[index + (page - 1) * 5].Quantity}개");
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.SetCursorPosition(0, 5);
            Console.WriteLine($"{page} 페이지");
            Console.WriteLine("[결정] : 번호    [뒤로가기] : ESC    [현재 장비] : C");
        }

        public override void Update()
        {
            switch (input)
            {
                case ConsoleKey.RightArrow:
                    if (Game.Player.eInventory.Count > page * 5)
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
                    chosenItem = Game.equipableDic[Game.Player.eInventory[0 + (page - 1) * 5].Name];
                    break;
                case ConsoleKey.D2:
                    chosenItem = Game.equipableDic[Game.Player.eInventory[1 + (page - 1) * 5].Name];
                    break;
                case ConsoleKey.D3:
                    chosenItem = Game.equipableDic[Game.Player.eInventory[2 + (page - 1) * 5].Name];
                    break;
                case ConsoleKey.D4:
                    chosenItem = Game.equipableDic[Game.Player.eInventory[3 + (page - 1) * 5].Name];
                    break;
                case ConsoleKey.D5:
                    chosenItem = Game.equipableDic[Game.Player.eInventory[4 + (page - 1) * 5].Name];
                    break;
            }
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.Escape:
                    Game.PreviousScene();
                    break;
                case ConsoleKey.C:
                    Game.OverlapScene("EquipStat");
                    break;
                case ConsoleKey.D1:
                    Game.OverlapScene("Equip");
                    break;
                case ConsoleKey.D2:
                    Game.OverlapScene("Equip");
                    break;
                case ConsoleKey.D3:
                    Game.OverlapScene("Equip");
                    break;
                case ConsoleKey.D4:
                    Game.OverlapScene("Equip");
                    break;
                case ConsoleKey.D5:
                    Game.OverlapScene("Equip");
                    break;
            }
        }
    }
}
