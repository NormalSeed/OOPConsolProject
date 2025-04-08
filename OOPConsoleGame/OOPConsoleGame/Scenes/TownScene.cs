using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame.Scenes
{
    public class TownScene : BaseScene
    {
        private string[] mapData;
        private bool[,] map;

        public TownScene()
        {
            mapData = new string[]
            {
                "###############",
                "#        ▲    #",
                "##            #",
                "#             #",
                "#           ###",
                "#             #",
                "#             #",
                "#   ▲▲▲       #",
                "#   ▲▲        #",
                "###############"
            };
            map = new bool[10, 15];
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 15; x++)
                {
                    map[y, x] = mapData[y][x] == ' ' ? true : false;
                }
            }
        }
        public override void Render()
        {
            PrintMap();
            Console.WriteLine("당신은 꿈에서 깨어난 뒤, 손에 새겨진 문양의 의미를 알기 위해 움직입니다.");
            Console.WriteLine("눈앞에 펼쳐진 마을 광장은 여느때처럼 한산합니다.");
            Console.WriteLine();
        }

        public override void Update()
        {
            
        }

        public override void Result()
        {
            
        }
        private void PrintMap()
        {
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y, x] == true)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write(mapData[y][x]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
