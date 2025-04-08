using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame
{
    public class Player
    {
        private int level;
        private int atk;
        private int def;
        private int spd;
        public Position position;
        public bool[,] map;

        public void SetPosition(int x, int y)
        {
            position.x = x;
            position.y = y;
        }
        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write('P');
            Console.ResetColor();
        }

        public void Move(ConsoleKey input)
        {
            Position targetPos = position;
            switch(input)
            {
                case ConsoleKey.W:
                    targetPos.y--;
                        break;
                case ConsoleKey.S:
                    targetPos.y++;
                    break;
                case ConsoleKey.A:
                    targetPos.x--;
                    break;
                case ConsoleKey.D:
                    targetPos.x++;
                    break;
            }

            if (map[targetPos.y, targetPos.x] == true)
            {
                position = targetPos;
            }
        }

        public void OpneInven()
        {

        }
    }
}
