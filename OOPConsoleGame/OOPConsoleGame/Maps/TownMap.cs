using OOPConsoleGame.Objects;
using OOPConsoleGame.Scenes;

namespace OOPConsoleGame.Maps
{
    public class TownMap : IMap
    {
        private string[] mapData;
        private bool[,] map;

        private List<GameObject> gameObjects;

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
            Game.Player.position = new Position(1, 1);
            Game.Player.map = map;

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("ElderHouse", ConsoleColor.Blue, 'E', new Position(13, 1)));
            gameObjects.Add(new Place("Smithery", ConsoleColor.DarkRed, 'S', new Position(1, 7)));
            gameObjects.Add(new Place("RianHouse", ConsoleColor.DarkGreen, 'R', new Position(12, 8)));
            gameObjects.Add(new Place("NorthForest", ConsoleColor.Green, 'F', new Position(13, 5)));
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

        public void DelObject(GameObject go)
        {
            int index = gameObjects.IndexOf(go);
            gameObjects.RemoveAt(index);
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
                        TownScene.isInit = true;
                    }
                    break;
                }
            }
        }
    }
}
