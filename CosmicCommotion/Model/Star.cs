namespace CosmicCommotion.Model
{
    public class Star
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int ScoreValue { get; private set; }
        public bool IsCollected { get; private set; }

        public Star(int x, int y, int scoreValue)
        {
            X = x;
            Y = y;
            ScoreValue = scoreValue;
            IsCollected = false;
        }

        public void Collect()
        {
            if (!IsCollected)
            {
                IsCollected = true;
                Disappear();
            }
        }

        public void Disappear()
        {
            X = -100;
            Y = -100;
        }

        public bool CheckCollisionWithSpaceShip(SpaceShip spaceShip)
        {
            return X == spaceShip.X && Y == spaceShip.Y;
        }
    }
}