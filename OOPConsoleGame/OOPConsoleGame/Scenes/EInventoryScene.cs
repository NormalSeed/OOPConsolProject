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
        public static Item chosenItem;
        public override void Render()
        {
            Console.Clear();

            if (Game.Player.Einventory.Count >= 1)
            {
                for (int i = 0; i < Game.Player.Einventory.Count; i++)
                {
                    int index = i % 5;
                    if (Game.Player.Einventory[i] != null)
                    {
                        Console.WriteLine($"{index + 1}. {Game.Player.Einventory[index + (page - 1) * 5].Name} " +
                            $": {Game.Player.Einventory[index + (page - 1) * 5].Quantity}개");
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.SetCursorPosition(0, 5);
            Console.WriteLine($"{page} 페이지");
            Console.WriteLine("[결정] : 번호    [뒤로가기] : ESC");
        }

        public override void Update()
        {
            switch (input)
            {
                case ConsoleKey.RightArrow:
                    if (Game.Player.Einventory.Count > page * 5)
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
                    chosenItem = Game.Player.Einventory[1 + (page - 1) * 5];
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
            switch (input)
            {
                case ConsoleKey.Escape:
                    Game.PreviousScene();
                    break;
            }
        }
    }
}
