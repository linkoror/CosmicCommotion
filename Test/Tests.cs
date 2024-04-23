using System;
using CosmicCommotion.Model;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.True(true);
        }
    }
    
    [TestFixture]
    public class SpaceShipGameTests
    {
        [Test]
        public void TestShipMovesUp()
        {
            SpaceShip ship = new SpaceShip(0, 0, 1, 3);

            ship.MoveUp();

            Assert.AreEqual(0, ship.X);
            Assert.AreEqual(-1, ship.Y);
        }

        [Test]
        public void TestShipCollectsStar()
        {
            SpaceShip ship = new SpaceShip(0, 0, 1, 3);
            int initialScore = 0;
        
            ship.CollectStar();
            int updatedScore = ship.Score;
        
            Assert.AreEqual(initialScore + 100, updatedScore);
        }

        [Test]
        public void TestShipHitByAsteroid()
        {
            SpaceShip ship = new SpaceShip(0, 0, 1, 3);
            int initialHealth = ship.Health;

            ship.ApplyDamage(2);
            int updatedHealth = ship.Health;

            Assert.AreEqual(initialHealth - 2, updatedHealth);
        }
        
        [Test]
        public void TestGameLevelIncreases()
        {
            SpaceShip ship = new SpaceShip(0, 0, 1, 3);
            int initialLevel = 1;

            ship.CollectStar();
            int updatedLevel = ship.Level;

            Assert.AreEqual(initialLevel, updatedLevel);
        }

        [Test]
        public void TestGameEndsWhenShipDestroyed()
        {
            SpaceShip ship = new SpaceShip(0, 0, 1, 3);
            
            ship.ApplyDamage(3);

            Assert.IsTrue(ship.IsDestroyed);
        }
    }
    
    [TestFixture]
    public class AsteroidTests
    {
        [Test]
        public void TestAsteroidMove()
        {
            Asteroid asteroid = new Asteroid(10, 10, 1, 3);
            int initialX = asteroid.X;

            asteroid.Move();

            Assert.AreEqual(initialX - 1, asteroid.X);
        }

        [Test]
        public void TestAsteroidDestroy()
        {
            Asteroid asteroid = new Asteroid(10, 10, 1, 3);

            asteroid.Destroy();

            Assert.IsTrue(asteroid.IsDestroyed);
        }

        [Test]
        public void TestAsteroidTakeDamage()
        {
            Asteroid asteroid = new Asteroid(10, 10, 1, 3);
            int initialSize = asteroid.Size;
        
            asteroid.TakeDamage(2);
        
            Assert.AreEqual(initialSize - 2, asteroid.Size);
        }
        
        [Test]
        public void TestAsteroidSplit()
        {
            Asteroid asteroid = new Asteroid(10, 10, 1, 3);
        
            asteroid.Split();
        
            Assert.IsTrue(asteroid.IsDestroyed);
        }
        
        [Test]
        public void TestAsteroidPlaceRandomly()
        {
            Asteroid asteroid = new Asteroid(0, 0, 1, 3);
            int initialX = asteroid.X;
            int initialY = asteroid.Y;
        
            asteroid.PlaceRandomly(100, 100);
        
            Assert.IsTrue(asteroid.X >= 0 && asteroid.X < 100);
            Assert.IsTrue(asteroid.Y >= 0 && asteroid.Y < 100);
            Assert.AreNotEqual(initialX, asteroid.X);
            Assert.AreNotEqual(initialY, asteroid.Y);
        }
        
        [Test]
        public void TestAsteroidExplode()
        {
            Asteroid asteroid = new Asteroid(10, 10, 1, 3);
        
            asteroid.Explode();
        
            Assert.IsTrue(asteroid.IsDestroyed);
        }
        
        [Test]
        public void TestAsteroidCheckCollisionWithSpaceShip()
        {
            Asteroid asteroid = new Asteroid(10, 10, 1, 3);
            SpaceShip spaceShip = new SpaceShip(10, 10, 1, 100);
        
            bool result = asteroid.CheckCollisionWithRocket(spaceShip);
        
            Assert.IsTrue(result);
        }
        
        [Test]
        public void TestAsteroidMoveLeft()
        {
            Asteroid asteroid = new Asteroid(10, 10, 1, 3);
            int initialX = asteroid.X;
        
            asteroid.Move();
        
            Assert.AreEqual(initialX - 1, asteroid.X);
        }
        
        [Test]
        public void TestAsteroidMoveDown()
        {
            Asteroid asteroid = new Asteroid(10, 10, 1, 3);
            int initialY = asteroid.Y;
        
            asteroid.MoveDown();
        
            Assert.AreEqual(initialY + 1, asteroid.Y);
        }
    }
}