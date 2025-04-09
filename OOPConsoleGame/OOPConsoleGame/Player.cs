using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleGame.Items;

namespace OOPConsoleGame
{
    public class Player
    {
        public int level;
        public int maxHp;
        public int curHp;
        public int atk;
        public int def;
        public int spd;
        public Position position;
        public bool[,] map;
        public List<Item> inventory;
        public Dictionary<string, IEquipable> equipments;
        public List<Item> eInventory;

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

        public void ShowStatus()
        {
            Console.WriteLine($"Lvl    : {level}");
            Console.WriteLine($"체력   : {curHp}/{maxHp}");
            Console.WriteLine($"공격력 : {atk}");
            Console.WriteLine($"방어력 : {def}");
            Console.WriteLine($"속도   : {spd}");
        }
        public void ShowEquipments()
        {
            Console.WriteLine("착용 장비");
            string[] slotType = { "Weapon", "Armor", "Boots" };

            for ( int i = 0; i < 3; i++)
            {
                if (equipments[slotType[i]] != null)
                {
                    Console.WriteLine($"{slotType[i]} : {equipments[slotType[i]].Name}");
                }
            }
        }

        public void EquipItem(string slot, IEquipable item)
        {
            equipments[slot] = item;
            int index = eInventory.FindIndex(i => i.Name == item.Name);
            eInventory[index].Quantity -= 1;
            if (eInventory[index].Quantity < 1)
            {
                eInventory.RemoveAt(index);
            }    
            item.IsEquipped = true;
            item.Equip();
        }

        public void UnequipItem(string slot)
        {
            eInventory.Add(new Item(equipments[slot].Name, 1));
            if (equipments.ContainsKey(slot))
            {
                IEquipable item = equipments[slot];
                item.Unequip();
                equipments.Remove(slot);
                if (slot == "Weapon")
                {
                    equipments.Add(slot, new Weapon("빈 슬롯", 0, "Weapon"));
                }
                else if (slot == "Armor")
                {
                    equipments.Add(slot, new Armor("빈 슬롯", 0, "Armor"));
                }
                else if (slot == "Boots")
                {
                    equipments.Add(slot, new Boots("빈 슬롯", 0, "Boots"));
                }
            }
        }
    }
}
