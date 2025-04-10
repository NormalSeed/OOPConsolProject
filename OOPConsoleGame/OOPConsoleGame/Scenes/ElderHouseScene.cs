namespace OOPConsoleGame.Scenes
{
    public class ElderHouseScene : BaseScene
    {
        private bool isInit = true;
        public override void Render()
        {
            if (isInit)
            {
                Util.PrintS("당신은 마을 장로의 집으로 들어갔습니다.");
                Util.PrintS("\"여행을 떠나기 전에 물어볼 것이 있나?\"");
                Util.PrintS("당신은 장로의 물음에 대답합니다.");
                isInit = false;
            }
            else
            {
                Console.WriteLine("당신은 마을 장로의 집으로 들어갔습니다.");
                Console.WriteLine("\"여행을 떠나기 전에 물어볼 것이 있나?\"");
                Console.WriteLine("당신은 장로의 물음에 대답합니다.");
            }
            Console.WriteLine();
            Console.WriteLine("1. \"문양에 대해 자세히 알고 싶습니다.\"");
            Console.WriteLine("2. \"첫번째 봉인은 어디에 있습니까?\"");
            Console.WriteLine("3. 광장으로 돌아간다.");
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
                    Util.PrintS("\"그 문양의 진정한 의미를 알아내기 위해서는 오래된 고서가 필요하다네.\"");
                    Util.PrintS("\"그 고서는 북쪽 숲의 폐허의 지하실에 있다는 전설이 전해지지...");
                    Util.Wait();
                    Console.Clear();
                    break;
                case ConsoleKey.D2:
                    Util.PrintS("\"봉인에 대한 것은 그다지 알려진 것이 없네...\"");
                    Util.PrintS("\"그저 문양을 가진 자가 나타나면 자연스럽게 알게 될 것이라고만 전해지지.\"");
                    Util.Wait();
                    Console.Clear();
                    break;
                case ConsoleKey.D3:
                    Util.PrintS("당신은 장로의 집을 나와 광장으로 돌아갑니다.");
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
