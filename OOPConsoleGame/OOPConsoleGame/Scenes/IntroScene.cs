using System.Runtime.InteropServices;

namespace OOPConsoleGame.Scenes
{
    public class IntroScene : BaseScene
    {
        private bool isInit = true;
        public override void Render()
        {
            Console.Clear();
            if (isInit)
            {
                Console.WriteLine("***  어둠의 서막  ***");
                Util.PrintS("밤하늘은 잔뜩 찌푸린 구름으로 덮여 있었고, 달빛조차도 두꺼운 장막을 뚫고 내려오지 못했다.");
                Util.PrintS("오래된 전설에 따르면, 이 세상에는 네 개의 마법의 봉인이 존재하며,\n그 봉인은 인간과 신들의 세계를 나누는 역할을 한다고 한다.");
                Util.PrintS("그러나 최근, 작은 마을 곳곳에서 봉인이 약해졌다는 소문이 돌기 시작했다.");
                Console.WriteLine();
                Util.PrintS("당신은 이 전설과 무관한 삶을 살아가던 평범한 사람이었다. 이름 없는 마을의 수습 대장장이로서,\n매일 아침 쇠망치를 들고 하루를 시작한다.");
                Util.PrintS("하지만 어느 날 밤, 당신은 기이한 꿈을 꾸었다. 꿈속에서 불길한 목소리가 당신을 부르는 소리가 들렸다.");
                Util.PrintS("\"시간이 없다... 그들이 다시 깨어나고 있다. 너는 선택받았다.\"");
                Util.PrintS("깨어났을 때, 당신의 손바닥에는 이상한 문양이 새겨져 있었다.");
                Util.PrintS("아무리 닦아내도 사라지지 않는 그 문양에 대해 물어보기 위해서 당신은 마을 장로를 찾아갔다.");
                Util.PrintS("당신의 손바닥의 문양을 본 장로는 표정이 굳어지며 말했다.");
                Util.PrintS("\"이 문양은... 전설에 나오는 '파멸의 인도자'의 증표다. 네가 봉인을 찾아야만 한다.\"");
                Console.WriteLine();
                Util.PrintS("이제 평온하던 당신의 일상은 끝났다.");
                Util.PrintS("네 개의 봉인을 찾아야 하는 여행이 시작되었고, 모든 것은 당신의 선택에 달렸다.");
                Util.PrintS("동료를 찾고, 적을 물리치며, 점차 다가오는 파멸의 진실을 마주하라.");
                isInit = false;
            }
            else
            {
                Console.WriteLine("***  어둠의 서막  ***");
                Console.WriteLine("밤하늘은 잔뜩 찌푸린 구름으로 덮여 있었고, 달빛조차도 두꺼운 장막을 뚫고 내려오지 못했다.");
                Console.WriteLine("오래된 전설에 따르면, 이 세상에는 네 개의 마법의 봉인이 존재하며,\n그 봉인은 인간과 신들의 세계를 나누는 역할을 한다고 한다.");
                Console.WriteLine("그러나 최근, 작은 마을 곳곳에서 봉인이 약해졌다는 소문이 돌기 시작했다.");
                Console.WriteLine();
                Console.WriteLine("당신은 이 전설과 무관한 삶을 살아가던 평범한 사람이었다. 이름 없는 마을의 수습 대장장이로서,\n매일 아침 쇠망치를 들고 하루를 시작한다.");
                Console.WriteLine("하지만 어느 날 밤, 당신은 기이한 꿈을 꾸었다. 꿈속에서 불길한 목소리가 당신을 부르는 소리가 들렸다.");
                Console.WriteLine("\"시간이 없다... 그들이 다시 깨어나고 있다. 너는 선택받았다.\"");
                Console.WriteLine("깨어났을 때, 당신의 손바닥에는 이상한 문양이 새겨져 있었다.");
                Console.WriteLine("아무리 닦아내도 사라지지 않는 그 문양에 대해 물어보기 위해서 당신은 마을 장로를 찾아갔다.");
                Console.WriteLine("당신의 손바닥의 문양을 본 장로는 표정이 굳어지며 말했다.");
                Console.WriteLine("\"이 문양은... 전설에 나오는 '파멸의 인도자'의 증표다. 네가 봉인을 찾아야만 한다.\"");
                Console.WriteLine();
                Console.WriteLine("이제 평온하던 당신의 일상은 끝났다.");
                Console.WriteLine("네 개의 봉인을 찾아야 하는 여행이 시작되었고, 모든 것은 당신의 선택에 달렸다.");
                Console.WriteLine("동료를 찾고, 적을 물리치며, 점차 다가오는 파멸의 진실을 마주하라.");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. 다음으로");
            Console.WriteLine("2. 타이틀 화면");
        }

        public override void Update()
        {

        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("Town");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Title");
                    break;
            }
        }
    }
}
