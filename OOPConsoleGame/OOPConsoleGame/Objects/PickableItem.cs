using OOPConsoleGame.Items;

namespace OOPConsoleGame.Objects
{
    public class PickableItem : GameObject
    {
        private Item item;

        public PickableItem(Item item, ConsoleColor color, char symbol, Position position)
            : base(color, symbol, position)
        {
            this.item = item;
        }
        public override void Interact(Player player)
        {
            player.inventory.Add(item);
        }
    }
}
