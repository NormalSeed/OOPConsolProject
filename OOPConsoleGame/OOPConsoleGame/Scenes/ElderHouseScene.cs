using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame.Scenes
{
    public class ElderHouseScene : BaseScene
    {
        public override void Render()
        {
            Console.WriteLine("당신은 마을 장로의 집으로 들어갔습니다.");
            Console.WriteLine("\"여행을 떠나기 전에 물어볼 것이 있나?\"");
            Console.WriteLine("당신은 장로의 물음에 대답합니다.");
            Console.WriteLine("1. ");
        }

        public override void Update()
        {
            
        }

        public override void Result()
        {
            
        }
    }
}
