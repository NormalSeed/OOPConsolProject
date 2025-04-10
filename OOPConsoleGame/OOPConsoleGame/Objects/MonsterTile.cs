using OOPConsoleGame.Scenes;

namespace OOPConsoleGame.Objects
{
    public class MonsterTile : GameObject
    {
        private Monster monster;

        public MonsterTile(Monster monster, ConsoleColor color, char symbol, Position position)
            : base(color, symbol, position)
        {
            this.monster = monster;
        }
        public override void Interact(Player player)
        {
            BattleScene.monster = monster;
            Game.OverlapScene("Battle");
        }
    }
}
