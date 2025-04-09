using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using OOPConsoleGame.Scenes;
using OOPConsoleGame.Items;

namespace OOPConsoleGame
{
    public class Game
    {
        //게임 정보

        private static bool gameOver;

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
            sceneDic.Add("EInventory", new EInventoryScene());
            sceneDic.Add("EquipStat", new EquipStatScene());
            sceneDic.Add("Equip", new EquipScene());
            sceneDic.Add("Unequip", new UnequipScene());
            sceneDic.Add("Status", new StatusScene());

            usableDic = new Dictionary<string, IUsable>();
            usableDic.Add("Low Potion", new Potion("하급 포션", 5));

            equipableDic = new Dictionary<string, IEquipable>();
            equipableDic.Add("단단한 철검", new Weapon("단단한 철검", 3, "Weapon"));

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
            player.equipments.Add("Weapon", new Weapon("빈 슬롯", 0, "Weapon"));
            player.equipments.Add("Armor", new Armor("빈 슬롯", 0, "Armor"));
            player.equipments.Add("Boots", new Boots("빈 슬롯", 0, "Boots"));
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
