using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame.Maps
{
    public class TownMap : IMap
    {
        private string[] mapData;
        private bool[,] map;
        public void CreateMap()
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
        public void PrintMap()
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
