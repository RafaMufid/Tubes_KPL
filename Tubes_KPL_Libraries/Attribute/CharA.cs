namespace Tubes_KPL_Libraries.Attribute
{
    public class CharA
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
}
