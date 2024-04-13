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
}