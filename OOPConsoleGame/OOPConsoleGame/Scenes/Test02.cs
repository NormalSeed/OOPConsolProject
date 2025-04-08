using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame.Scenes
{
    public class Test02 : BaseScene
    {
        public override void Render()
        {
            Console.WriteLine("1번 테스트씬입니다.");
            Console.WriteLine();
            Console.WriteLine("1. 타이틀로 돌아가기");
            Console.WriteLine("2. 1번 테스트씬으로");
            Console.WriteLine("3. 3번 테스트씬으로");
        }

        public override void Update()
        {

        }

        public override void Result()
        {
            switch(input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("Title");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Test01");
                    break;
                case ConsoleKey.D3:
                    Game.ChangeScene("Test03");
                    break;

            }
        }
    }
}
