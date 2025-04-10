using OOPConsoleGame.Items;
using OOPConsoleGame.Scenes;

namespace OOPConsoleGame
{
    public class Game
    {
        //게임 데이터

        public static bool gameOver;

        private static Stack<string> uiStack = new Stack<string>();
        private static Dictionary<string, BaseScene> sceneDic;
        private static BaseScene curScene;

        public static Dictionary<string, IUsable> usableDic;
        public static Dictionary<string, IEquipable> equipableDic;

        private static Player player;

        public static Player Player { get { return player; } set { player = value; } }


        public static void Start()
        {
            Console.CursorVisible = false;
            //게임 시작 설정
            gameOver = false;

            //씬 설정
            sceneDic = new Dictionary<string, BaseScene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Intro", new IntroScene());
            sceneDic.Add("Town", new TownScene());
            sceneDic.Add("ElderHouse", new ElderHouseScene());
            sceneDic.Add("Smithery", new SmitheryScene());
            sceneDic.Add("SmithTrade", new SmithTradeScene());
            sceneDic.Add("RianHouse", new RianHouseScene());
            sceneDic.Add("Inventory", new InventoryScene());
            sceneDic.Add("Use", new UseScene());
            sceneDic.Add("EInventory", new EInventoryScene());
            sceneDic.Add("EquipStat", new EquipStatScene());
            sceneDic.Add("Equip", new EquipScene());
            sceneDic.Add("Unequip", new UnequipScene());
            sceneDic.Add("Status", new StatusScene());
            sceneDic.Add("NorthForest", new NorthForestScene());
            sceneDic.Add("Battle", new BattleScene());

            usableDic = new Dictionary<string, IUsable>();
            usableDic.Add("하급 포션", new Potion("하급 포션", 5));
            usableDic.Add("중급 포션", new Potion("중급 포션", 10));

            equipableDic = new Dictionary<string, IEquipable>();
            equipableDic.Add("단단한 철검", new Weapon("단단한 철검", 3, "Weapon"));
            equipableDic.Add("철검", new Weapon("철검", 2, "Weapon"));
            equipableDic.Add("질긴 가죽갑옷", new Armor("질긴 가죽갑옷", 3, "Armor"));
            equipableDic.Add("가죽 부츠", new Boots("가죽 부츠", 2, "Boots"));

            uiStack = new Stack<string>();
            uiStack.Push("Title");
            curScene = sceneDic[uiStack.Peek()];

            //플레이어 설정
            player = new Player();
            player.level = 1;
            player.maxHp = 10;
            player.curHp = 10;
            player.atk = 5;
            player.def = 5;
            player.spd = 5;
            player.inventory = new List<Item>();
            player.inventory.Add(new Item("Gold", 300));
            player.inventory.Add(new Item("하급 포션", 5));
            player.equipments = new Dictionary<string, IEquipable>();
            player.equipments.Add("Weapon", null);
            player.equipments.Add("Armor", null);
            player.equipments.Add("Boots", null);
            player.eInventory = new List<Item>();
        }
        public static void Run()
        {
            Start();

            while (gameOver == false)
            {
                curScene.Render();
                curScene.Input();
                curScene.Update();
                curScene.Result();
            }
        }
        public static void End()
        {
            Console.WriteLine("게임을 다시 시작하세요");
            Util.Wait();
        }

        public static void ChangeScene(string sceneName)
        {
            uiStack.Pop();
            uiStack.Push(sceneName);
            curScene = sceneDic[uiStack.Peek()];
            Console.Clear();
        }

        public static void OverlapScene(string sceneName)
        {
            uiStack.Push(sceneName);
            curScene = sceneDic[uiStack.Peek()];
            Console.Clear();
        }

        public static void PreviousScene()
        {
            uiStack.Pop();
            curScene = sceneDic[uiStack.Peek()];
            Console.Clear();
        }
    }
}
