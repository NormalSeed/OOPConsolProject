namespace OOPConsoleGame
{
    public class Monster
    {
        public string name;
        public int level;
        public int maxHp;
        public int hp;
        public int atk;
        public int def;
        public int spd;
        public bool isDead;

        public Monster(string name, int level, int maxHp, int hp, int atk, int def, int spd, bool isDead = false)
        {
            this.name = name;
            this.level = level;
            this.maxHp = maxHp;
            this.hp = hp;
            this.atk = atk;
            this.def = def;
            this.spd = spd;
        }

        public void TakeDMG()
        {
            if(def < Game.Player.atk)
            {
                hp += def - Game.Player.atk;
            }
            else
            {
                hp -= 1;
            }
        }

        public void GiveDMG()
        {
            if(Game.Player.def < atk)
            {
                Game.Player.curHp += Game.Player.def - atk;
            }
            else
            {
                Game.Player.curHp -= 1;
            }
        }

        public void DeathCheck()
        {
            if (hp <= 0)
            {
                Console.WriteLine($"{this.name}이/가 쓰러졌다!");
                isDead = true;
            }
        }
    }
}
