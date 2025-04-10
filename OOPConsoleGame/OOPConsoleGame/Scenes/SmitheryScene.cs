﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleGame.Items;

namespace OOPConsoleGame.Scenes
{
    public class SmitheryScene : BaseScene
    {
        public override void Render()
        {
            Util.PrintS("대장간의 주인인 대장장이 카르타가 당신을 힐끗 쳐다봅니다.");
            Util.PrintS("\"왔으면 자리로 가서 일을 시작해.\"");
            Util.PrintS("당신은 카르타에게 자초지종을 설명합니다...");
            Console.WriteLine();
            Console.WriteLine("1. 카르타에게 무기와 방어구를 부탁한다.");
            Console.WriteLine("2. 스스로 무기와 방어구를 제작한다.");
            Console.WriteLine("3. 대장간을 나간다.");
            Console.WriteLine();
        }

        public override void Update()
        {
            switch (input)
            {
                case ConsoleKey.D2:
                    Game.Player.eInventory.Add(new Item("철검", 1));
                    break;
            }
        }

        public override void Result()
        {
            Console.WriteLine();
            switch (input)
            {
                case ConsoleKey.D1:
                    Util.PrintS("설명을 끝낸 당신은 카르타에게 장비를 부탁합니다.");
                    Util.PrintS("\"장비를 갖고 싶으면 돈을 내야지. 비싸지는 않게 해주마. [200G]\"");
                    Util.Wait();
                    switch(input)
                    {
                        case ConsoleKey.D1:
                            Game.ChangeScene("SmithTrade");
                            break;
                    }    
                    break;
                case ConsoleKey.D2:
                    Util.PrintS("설명을 끝낸 당신은 대장간의 자신의 자리로 걸어갑니다.");
                    Util.PrintS("당신은 대장장이로서 실력을 최대한 발휘해 검을 한 자루 만듭니다.");
                    Util.PrintS("스스로 만든 검을 갖고 마을 광장으로 돌아갑니다.");
                    Util.Wait();
                    Game.ChangeScene("Town");
                    break;
                case ConsoleKey.D3:
                    Util.PrintS("당신은 다른 할 일이 떠올라 대장간을 나와 마을 광장으로 향합니다.");
                    Util.Wait();
                    Game.ChangeScene("Town");
                    break;
                default:
                    Console.WriteLine("1, 2, 3번 중에서 골라주세요.");
                    Console.ReadKey();
                    Console.Clear();
                    return;
            }
        }
    }
}