using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame.Scenes
{
    public class InventoryScene : BaseScene
    {
        List<Item> inventory = new List<Item>();
        public override void Render()
        {
            Console.Clear();
            //한 페이지에 5개씩 인벤토리의 물건을 보여주고
            //6번째 줄에는 소지 골드(G)
            //그 다음 줄에는 페이지수를 표시
            inventory = Game.Player.inventory;
            int page = 0;
            if (inventory.Count > 1)
            {
                for (int i = 1; i < 6; i++)
                {
                    Console.WriteLine($"{inventory[i + page * 5]}");
                }
            }
            Console.SetCursorPosition(0, 5);
            Console.WriteLine($"{inventory[0].Quantity} G");
            Console.WriteLine($"{page + 1} 페이지");
            Console.WriteLine("[결정] : 스페이스바    [뒤로가기] : ESC");
        }

        public override void Update()
        {
            
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
