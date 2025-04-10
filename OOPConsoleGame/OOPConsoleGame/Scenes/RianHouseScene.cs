using System.Runtime.InteropServices;

namespace OOPConsoleGame.Scenes
{
    public class RianHouseScene : BaseScene
    {
        private bool isInit = true;
        public override void Render()
        {
            if (isInit)
            {
                Util.PrintS("당신은 어릴 적 친구인 리안을 찾아왔습니다.");
                Util.PrintS("리안은 북쪽 숲 근처에서 종종 사냥을 합니다.");
                Util.PrintS("현관에 들어가니 이야기를 들었는지 리안이 걱정스러운 표정으로 바라봅니다.");
                Util.PrintS("\"네가 전설속의 파멸의 인도자라고? 그런 말도 안되는 일이...\"");
                isInit = false;
            }
            else
            {
                Console.WriteLine("당신은 어릴 적 친구인 리안을 찾아왔습니다.");
                Console.WriteLine("리안은 북쪽 숲 근처에서 종종 사냥을 합니다.");
                Console.WriteLine("현관에 들어가니 이야기를 들었는지 리안이 걱정스러운 표정으로 바라봅니다.");
                Console.WriteLine("\"네가 전설속의 파멸의 인도자라고? 그런 말도 안되는 일이...\"");
            }
            Console.WriteLine();
            Console.WriteLine("1. 리안에게 북쪽숲에 대해 물어본다.");
            Console.WriteLine("2. 리안에게 동료가 되기를 권유한다.");
            Console.WriteLine("3. 리안에게 작별인사를 하고 떠난다.");
            Console.WriteLine();
        }

        public override void Update()
        {

        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Util.PrintS("\"북쪽 숲에는 오래된 폐허 말고는 아무것도 없어.\"");
                    Util.PrintS("\"가끔 폐허 쪽에서 여자의 울음소리 같은게 들릴 때도 있지만\n분명 동물의 울음소리를 잘못 들은 거겠지.\"");
                    Util.Wait();
                    Console.Clear();
                    break;
                case ConsoleKey.D2:
                    Util.PrintS("\"나도 함께 떠나자고?\"");
                    Util.PrintS("\"너도 알다시피 우리 어머니가 아프셔서... 같이 떠나는건 무리야.\"");
                    Util.Wait();
                    Console.Clear();
                    break;
                case ConsoleKey.D3:
                    Util.PrintS("당신은 작별인사를 마치고 리안의 집을 나와 광장으로 돌아갑니다.");
                    Util.Wait();
                    Game.ChangeScene("Town");
                    break;
                default:
                    Console.WriteLine("1, 2, 3번 중에서 골라주세요.");
                    Console.ReadKey();
                    Console.Clear();
                    return;
            }
        }
    }
}
