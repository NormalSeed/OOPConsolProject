using OOPConsoleGame.Items;

namespace OOPConsoleGame.Objects
{
    public class PickableEquipment : GameObject
    {
        private Item item;

        public PickableEquipment(Item item, ConsoleColor color, char symbol, Position position)
            : base(color, symbol, position)
        {
            this.item = item;
        }
        public override void Interact(Player player)
        {
            player.eInventory.Add(item);
        }
    }
}
