using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleGame.Maps;

namespace OOPConsoleGame.Scenes
{
    public class TownScene : BaseScene
    {
        private TownMap townMap;
        private bool isInit = true;


        public override void Render()
        {
            if (isInit)
            {
                townMap = new TownMap();
                townMap.CreateMap();
                isInit = false;
            }
            townMap.PrintMap();
            Console.WriteLine("당신은 꿈에서 깨어난 뒤, 손에 새겨진 문양의 의미를 알기 위해 움직입니다.");
            Console.WriteLine("눈앞에 펼쳐진 마을 광장은 여느때처럼 한산합니다.");
            Console.WriteLine();

            townMap.SetObject();
            Game.Player.Print();
        }

        public override void Update()
        {
            Game.Player.Move(input);
        }

        public override void Result()
        {
            townMap.ObjInteract();
        }
    }
}
