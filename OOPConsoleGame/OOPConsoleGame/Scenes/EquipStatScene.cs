using OOPConsoleGame.Items;

namespace OOPConsoleGame.Scenes
{
    public class EquipStatScene : BaseScene
    {
        public static IEquipable chosenItem;
        public override void Render()
        {
            Console.Clear();
            Game.Player.ShowEquipments();
            Console.WriteLine();
            Console.WriteLine("1. 무기 해제");
            Console.WriteLine("2. 갑옷 해제");
            Console.WriteLine("3. 신발 해제");
            Console.WriteLine();
            Console.WriteLine("[뒤로가기] : ESC");
        }

        public override void Update()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    if (Game.Player.equipments["Weapon"] != null)
                    {
                        chosenItem = Game.Player.equipments["Weapon"];
                    }
                        break;
                case ConsoleKey.D2:
                    if (Game.Player.equipments["Armor"] != null)
                    {
                        chosenItem = Game.Player.equipments["Armor"];
                    }
                    break;
                case ConsoleKey.D3:
                    if (Game.Player.equipments["Boots"] != null)
                    {
                        chosenItem = Game.Player.equipments["Boots"];
                    }
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
                case ConsoleKey.D1:
                    if (Game.Player.equipments["Weapon"] != null)
                    {
                        Game.OverlapScene("Unequip");
                    }
                    else
                    {
                        Console.SetCursorPosition(0, 10);
                        Console.WriteLine("빈 슬롯입니다.");
                        Util.Wait();
                    }
                    break;
                case ConsoleKey.D2:
                    if (Game.Player.equipments["Armor"] != null)
                    {
                        Game.OverlapScene("Unequip");
                    }
                    else
                    {
                        Console.SetCursorPosition(0, 10);
                        Console.WriteLine("빈 슬롯입니다.");
                        Util.Wait();
                    }
                    break;
                case ConsoleKey.D3:
                    if (Game.Player.equipments["Boots"] != null)
                    {
                        Game.OverlapScene("Unequip");
                    }
                    else
                    {
                        Console.SetCursorPosition(0, 10);
                        Console.WriteLine("빈 슬롯입니다.");
                        Util.Wait();
                    }
                    break;
            }
        }
    }
}
