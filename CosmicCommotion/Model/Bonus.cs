namespace CosmicCommotion.Model
{
    public class Bonus
    {
        public int X { get; set; }
        public int Y { get; set; }
        public BonusType Type { get; set; }

        public Bonus(int x, int y, BonusType type)
        {
            X = x;
            Y = y;
            Type = type;
        }
    }


    public enum BonusType
    {
        Health,
        SpeedDecrease,
        Shield,
    }
}