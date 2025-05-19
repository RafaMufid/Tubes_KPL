namespace Tubes_KPL_Libraries.Attribute
{
    public class charactersAtribute
    {
        private int health = 100;
        private double gold;

        public int getHealth() { 
            return health;
        }
        public void setHealth(int health) => this.health = health;

        public double getGold() => gold;
        public void setGold(double gold) => this.gold = gold;
    }
    public class Charmons
    {
        public static readonly Random rng = new Random();
        private int health = rng.Next(100,500);
        public int getHealthmons()
        {
            return health;
        }
        public void setHealthmons(int health) {

            this.health = health;
        }
    }
}
