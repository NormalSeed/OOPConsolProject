namespace OOPConsoleGame
{
    public class MonsterFactory
    {
        public Monster Create(string name)
        {
            switch (name)
            {
                case "고블린":
                    return new Monster("고블린", 1, 7, 7, 6, 1, 4);
            }
            return null;
        }
    }
}
