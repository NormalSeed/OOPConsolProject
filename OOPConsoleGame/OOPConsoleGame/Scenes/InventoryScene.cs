﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleGame.Items;

namespace OOPConsoleGame.Scenes
{
    public class InventoryScene : BaseScene
    {
        List<Item> inventory = new List<Item>();
        private int page = 1;
        public override void Render()
        {
            Console.Clear();
            //한 페이지에 5개씩 인벤토리의 물건을 보여주고
            //6번째 줄에는 소지 골드(G)
            //그 다음 줄에는 페이지수를 표시
            inventory = Game.Player.inventory;
            if (inventory.Count > 1)
            {
                for (int i = 1; i < inventory.Count; i++)
                {
                    int index = i % 5;
                    if (inventory[i] != null)
                    {
                        Console.WriteLine($"{index}. {inventory[index + (page - 1) * 5].Name} " +
                            $": {inventory[index + (page - 1) * 5].Quantity}개");
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.SetCursorPosition(0, 5);
            Console.WriteLine($"{inventory[0].Quantity} G");
            Console.WriteLine($"{page + 1} 페이지");
            Console.WriteLine("[결정] : 번호    [뒤로가기] : ESC");
        }

        public override void Update()
        {
            switch(input)
            {
                case ConsoleKey.RightArrow:
                    if (inventory.Count > page * 5)
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

                    break;
                case ConsoleKey.D2:

                    break;
                case ConsoleKey.D3:

                    break;
                case ConsoleKey.D4:

                    break;
                case ConsoleKey.D5:

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
