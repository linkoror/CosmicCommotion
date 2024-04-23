using System;

namespace CosmicCommotion.Model
{
    public class Asteroid
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Speed { get; private set; }
        public int Size { get; private set; }
        public bool IsDestroyed { get; private set; }

        public Asteroid(int x, int y, int speed, int size)
        {
            X = x;
            Y = y;
            Speed = speed;
            Size = size;
            IsDestroyed = false;
        }

        public void Move()
        {
            X -= Speed;
        }

        public void Destroy()
        {
            IsDestroyed = true;
        }
        
        public void CollideWithRocket(SpaceShip spaceShip)
        {
            if (X == spaceShip.X && Y == spaceShip.Y)
            {
                spaceShip.TakeDamage(Size);
                Destroy();
            }
        }
        
        public void MoveDown()
        {
            Y += Speed;
        }
        
        // public void SpawnRandomly()
        // {
        //     Random random = new Random();
        //     int side = random.Next(2);
        //
        //     if (side == 0)
        //     {
        //         X = 0;
        //         Y = random.Next(GameField.Height);
        //     }
        //     else
        //     {
        //         X = random.Next(GameField.Width);
        //         Y = GameField.Height;
        //     }
        // }
        
        public void TakeDamage(int damage)
        {
            Size -= damage;
            if (Size <= 0)
            {
                Destroy();
            }
        }

        public void Split()
        {
            if (Size >= 2)
            {
                Asteroid asteroid1 = new Asteroid(X, Y, Speed + 1, Size - 1);
                Asteroid asteroid2 = new Asteroid(X, Y, Speed + 1, Size - 1);

                asteroid1.X -= 10;
                asteroid2.X += 10;
                
                Destroy();
            }
        }
        
        public void PlaceRandomly(int maxX, int maxY)
        {
            Random random = new Random();
            X = random.Next(0, maxX);
            Y = random.Next(0, maxY);
        }

        public void Explode()
        {
            Destroy();
        }

        public bool CheckCollisionWithRocket(SpaceShip spaceShip)
        {
            return X == spaceShip.X && Y == spaceShip.Y;
        }
    }
}