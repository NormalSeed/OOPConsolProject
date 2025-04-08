using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using OOPConsoleGame.Scenes;

namespace OOPConsoleGame
{
    internal class Game
    {
        //게임 정보

        private static bool gameOver;

        private static Dictionary<string, BaseScene> sceneDic;
        private static BaseScene curScene;
        private static Player player;

        public static Player Player { get { return player; } }


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

            curScene = sceneDic["Title"];

            //플레이어 설정
            player = new Player();
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
            curScene = sceneDic[sceneName];
            Console.Clear();
        }
    }
}
