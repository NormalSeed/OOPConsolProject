namespace OOPConsoleGame.Items
{
    public class Weapon : IEquipable
    {
        public string Name { get; set; }
        public int Atk { get; set; }
        public string type { get; set; }
        public Weapon(string name, int atk, string type, bool isEquipped = false)
        {
            Name = name;
            Atk = atk;
            this.type = type;
        }

        public void Equip()
        {
            Game.Player.atk += Atk;
        }

        public void Unequip()
        {
            Game.Player.atk -= Atk;
        }
    }
}
