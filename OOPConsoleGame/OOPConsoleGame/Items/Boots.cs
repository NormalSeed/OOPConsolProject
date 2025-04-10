namespace OOPConsoleGame.Items
{
    public class Boots : IEquipable
    {
        public string Name { get; set; }
        public int Spd { get; set; }
        public string type { get; set; }
        public Boots(string name, int spd, string type, bool isEquipped = false)
        {
            Name = name;
            Spd = spd;
            this.type = type;
        }

        public void Equip()
        {
            Game.Player.spd += Spd;
        }

        public void Unequip()
        {
            Game.Player.spd -= Spd;
        }
    }
}
