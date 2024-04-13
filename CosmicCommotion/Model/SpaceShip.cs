namespace CosmicCommotion.Model
{
    public class SpaceShip
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }

        public SpaceShip(int x, int y, int health)
        {
            X = x;
            Y = y;
            Health = health;
        }

        public void MoveUp()
        {
            
        }
        
        public void MoveDown()
        {
            
        }
    }
}