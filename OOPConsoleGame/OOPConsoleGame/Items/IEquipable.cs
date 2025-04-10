namespace OOPConsoleGame.Items
{
    public interface IEquipable
    {
        string Name { get; set; }
        string type { get; set; }
        public void Equip();
        public void Unequip();
    }
}
