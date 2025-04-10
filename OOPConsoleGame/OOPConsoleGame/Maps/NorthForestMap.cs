using OOPConsoleGame.Items;
using OOPConsoleGame.Objects;
using OOPConsoleGame.Scenes;

namespace OOPConsoleGame.Maps
{
    public class NorthForestMap : IMap
    {
        private string[] mapData;
        public bool[,] map;

        private List<GameObject> gameObjects;
        public void CreateMap()
        {
            mapData = new string[]
            {
                "▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲",
                "▲      ▲      ▲",
                "▲  ▲▲▲ ▲    ▲ ▲",
                "▲  ▲   ▲  ▲▲▲▲▲",
                "▲          ▲  ▲",
                "▲▲▲▲▲▲     ▲  ▲",
                "▲       ▲▲▲▲  ▲",
                "▲ ▲▲▲▲     ▲  ▲",
                "▲ ▲           ▲",
                "▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲"
            };
            map = new bool[10, 15];
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 15; x++)
                {
                    map[y, x] = mapData[y][x] == ' ' ? true : false;
                }
            }
            Game.Player.position = new Position(1, 7);
            Game.Player.map = map;
            MonsterFactory nFMonsterFactory = new MonsterFactory();
            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("AncientRuin", ConsoleColor.White, 'A', new Position(13, 2)));
            gameObjects.Add(new Place("Town", ConsoleColor.White, 'T', new Position(1, 8)));
            gameObjects.Add(new PickableItem(new Item("중급 포션", 1), ConsoleColor.DarkYellow, 'i', new Position(12, 4)));
            gameObjects.Add(new PickableEquipment(new Item("가죽 부츠", 1), ConsoleColor.Cyan, 'E', new Position(6, 1)));
            gameObjects.Add(new MonsterTile(nFMonsterFactory.Create("고블린"), ConsoleColor.DarkRed, 'M', new Position(12, 1)));
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

        public void SetObject()
        {
            foreach (GameObject go in gameObjects)
            {
                go.Print();
            }
        }

        public void ObjInteract()
        {
            for (int i = 0; i < gameObjects.Count; i++)
            {
                GameObject go = gameObjects[i];
                if (Game.Player.position.x == go.position.x &&
                    Game.Player.position.y == go.position.y)
                {
                    go.Interact(Game.Player);

                    if (!(go is Place))
                    {
                        gameObjects.RemoveAt(i);
                    }
                    else
                    {
                        NorthForestScene.isInit = true;
                    }
                    break;
                }
            }
        }
    }
}
