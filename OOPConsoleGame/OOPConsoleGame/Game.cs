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
        private static bool gameOver;

        private static Dictionary<string, BaseScene> sceneDic;
        private static BaseScene curScene;
        public static void Start()
        {
            gameOver = false;
            sceneDic = new Dictionary<string, BaseScene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Test01", new Test01());
            sceneDic.Add("Test02", new Test02());
            sceneDic.Add("Test03", new Test03());

            curScene = sceneDic["Title"];
        }
        public static void Run()
        {
            Start();

            while (gameOver == false)
            {
                Console.Clear();
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
        }
    }
}
