using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame.Scenes
{
    public class BattleScene : BaseScene
    {
        public static new Monster monster;
        public override void Render()
        {
            Console.WriteLine("몬스터 조우!!");
            Console.Clear();
            Console.WriteLine($"{monster.name}  lvl  {monster.level}");
            Console.WriteLine($"HP  {monster.hp} / {monster.maxHp}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("나");
            Console.WriteLine($"HP  {Game.Player.curHp} / {Game.Player.maxHp}");
            Console.WriteLine();
            Console.WriteLine("1. 공격");
            Console.WriteLine("2. 도망");
        }

        public override void Update()
        {
            //선택지에 따른 몬스터, 플레이어 체력 증감, 속도에 따른 도망여부 판정
            switch (input)
            {
                case ConsoleKey.D1:
                    if (Game.Player.spd > monster.spd)
                    {
                        monster.TakeDMG();
                        monster.DeathCheck();
                        if (monster.isDead)
                        {
                            Util.Wait();
                        }
                        monster.GiveDMG();
                        Game.Player.DeathCheck();
                        if (Game.Player.isDead)
                        {
                            Util.Wait();
                        }
                    }
                    else
                    {
                        monster.GiveDMG();
                        Game.Player.DeathCheck();
                        if (Game.Player.isDead)
                        {
                            Util.Wait();
                            Game.ChangeScene("GameOver");
                        }
                        monster.TakeDMG();
                        monster.DeathCheck();
                        if (monster.isDead)
                        {
                            Util.Wait();
                            Game.PreviousScene();
                        }
                    }
                    break;
                case ConsoleKey.D2:
                    if (Game.Player.spd < monster.spd)
                    {
                        Console.WriteLine("걸음이 느려 도망칠 수 없습니다");
                        monster.GiveDMG();
                        Game.Player.DeathCheck();
                        if (Game.Player.isDead)
                        {
                            Util.Wait();
                        }
                    }
                        break;

            }
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    if (Game.Player.spd > monster.spd)
                    {
                        if (monster.isDead)
                        {
                            Game.PreviousScene();
                        }
                        if (Game.Player.isDead)
                        {
                            Game.ChangeScene("GameOver");
                        }
                    }
                    else
                    {
                        if (Game.Player.isDead)
                        {
                            Util.Wait();
                            Game.ChangeScene("GameOver");
                        }
                        if (monster.isDead)
                        {
                            Util.Wait();
                            Game.PreviousScene();
                        }
                    }
                    break;
                case ConsoleKey.D2:
                    if (Game.Player.spd < monster.spd)
                    {
                        Game.Player.DeathCheck();
                        if (Game.Player.isDead)
                        {
                            Game.ChangeScene("GameOver");
                        }
                    }
                    else
                    {
                        Random random = new Random();
                        int randNum = random.Next(1, 101);
                        int probability = Game.Player.spd * 100 / monster.spd - 100;

                        if (probability >= randNum)
                        {
                            Console.WriteLine("도망에 성공했습니다!");
                            Util.Wait();
                            Game.PreviousScene();
                        }
                        else
                        {
                            Console.WriteLine("도망에 실패했습니다");
                            monster.GiveDMG();
                            Game.Player.DeathCheck();
                            if (Game.Player.isDead)
                            {
                                Util.Wait();
                                Game.ChangeScene("GameOver");
                            }
                        }
                    }
                    break;
                case ConsoleKey.I:
                    Game.OverlapScene("Inventory");
                    break;
                case ConsoleKey.E:
                    Game.OverlapScene("EInventory");
                    break;
                case ConsoleKey.P:
                    Game.OverlapScene("Status");
                    break;
            }
        }
    }
}
