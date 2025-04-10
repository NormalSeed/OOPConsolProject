using OOPConsoleGame.Items;

namespace OOPConsoleGame.Scenes
{
    public class SmitheryScene : BaseScene
    {
        private bool isInit = true;
        private bool isBought = false;
        private bool isGet = false;
        public override void Render()
        {
            Game.Player.ItemAdded += OnItemAdded;
            if (isInit)
            {
                Util.PrintS("대장간의 주인인 대장장이 카르타가 당신을 힐끗 쳐다봅니다.\n" +
                    "\"왔으면 자리로 가서 일을 시작해.\"\n" +
                    "당신은 카르타에게 자초지종을 설명합니다...");
                isInit = false;
            }
            else
            {
                Console.WriteLine("대장간의 주인인 대장장이 카르타가 당신을 힐끗 쳐다봅니다.");
                Console.WriteLine("\"왔으면 자리로 가서 일을 시작해.\"");
                Console.WriteLine("당신은 카르타에게 자초지종을 설명합니다...");
            }
            Console.WriteLine();
            Console.WriteLine("1. 카르타에게 무기와 방어구를 부탁한다.");
            Console.WriteLine("2. 스스로 무기와 방어구를 제작한다.");
            Console.WriteLine("3. 대장간을 나간다.");
            Console.WriteLine();
        }

        public override void Update()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    if (isBought == false)
                    {
                        Util.PrintS("설명을 끝낸 당신은 카르타에게 장비를 부탁합니다.\n" +
                        "\"장비를 갖고 싶으면 돈을 내야지. 비싸지는 않게 해주마. [200G]\"");
                    }
                    else
                    {
                        Console.WriteLine("이미 장비를 구매했습니다.");
                    }

                        break;
                case ConsoleKey.D2:
                    if (isGet == false)
                    {
                        Util.PrintS("설명을 끝낸 당신은 대장간의 자신의 자리로 걸어갑니다.\n" +
                        "당신은 대장장이로서 실력을 최대한 발휘해 검을 한 자루 만듭니다.\n" +
                        "스스로 만든 검을 갖고 마을 광장으로 돌아갑니다.");
                        Game.Player.AddEInventory(new Item("철검", 1));
                        isGet = true;
                    }
                    else
                    {
                        Console.WriteLine("이미 장비를 만들었습니다.");
                    }
                    break;
                case ConsoleKey.D3:
                    Util.PrintS("당신은 다른 할 일이 떠올라 대장간을 나와 마을 광장으로 향합니다.");
                    break;
            }
        }

        public override void Result()
        {
            Game.Player.ItemAdded -= OnItemAdded;
            Console.WriteLine();
            switch (input)
            {
                case ConsoleKey.D1:
                    Util.Wait();
                    switch (input)
                    {
                        case ConsoleKey.D1:
                            if (isBought == false)
                            {
                                Game.ChangeScene("SmithTrade");
                                isBought = true;
                            }
                            else
                            {
                                Game.ChangeScene("Town");
                            }
                                break;
                    }
                    break;
                case ConsoleKey.D2:
                    Util.Wait();
                    Game.ChangeScene("Town");
                    break;
                case ConsoleKey.D3:
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
        private void OnItemAdded(string name)
        {
            Console.WriteLine($"{name}을/를 손에 넣었다!");
        }
    }
}