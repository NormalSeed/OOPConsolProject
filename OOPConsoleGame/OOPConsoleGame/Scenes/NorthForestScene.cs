using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleGame.Maps;

namespace OOPConsoleGame.Scenes
{
    public class NorthForestScene : BaseScene
    {
        private NorthForestMap nFMap;
        public static bool isInit = true;

        public override void Render()
        {
            if (isInit)
            {
                nFMap = new NorthForestMap();
                nFMap.CreateMap();
                isInit = false;
            }
            nFMap.PrintMap();
            Console.WriteLine("마을 북쪽에 있는 숲입니다. 멀리서 늑대 울음소리가 울려퍼집니다.");
            Console.WriteLine("숲에는 고블린의 둥지가 있습니다. 전투가 벌어질 것 같은 예감이 듭니다.");
            Console.WriteLine();

            nFMap.SetObject();
            Game.Player.Print();
        }
        public override void Update()
        {
            Game.Player.Move(input);
        }

        public override void Result()
        {
            nFMap.ObjInteract();

            switch (input)
            {
                case ConsoleKey.I:
                    Game.OverlapScene("Inventory");
                    break;
                case ConsoleKey.E:
                    Game.OverlapScene("EInventory");
                    break;
                case ConsoleKey.P:
                    Game.OverlapScene("Status");
                    break;
            }
        }
    }
}
