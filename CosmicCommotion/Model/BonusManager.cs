using System;
using System.Collections.Generic;

namespace CosmicCommotion.Model
{
    public class BonusManager
    {
        private List<Bonus> availableBonuses;
        private Random random;

        public BonusManager()
        {
            availableBonuses = new List<Bonus>();
            random = new Random();

            InitializeBonuses();
        }

        private void InitializeBonuses()
        {
            availableBonuses.Add(new Bonus(BonusType.SpeedBoost));
            availableBonuses.Add(new Bonus(BonusType.StarMagnet));
            availableBonuses.Add(new Bonus(BonusType.DamageBoost));
            availableBonuses.Add(new Bonus(BonusType.ShieldRecharge));
            availableBonuses.Add(new Bonus(BonusType.TimeFreeze));
            availableBonuses.Add(new Bonus(BonusType.WeaponUpgrade));
            availableBonuses.Add(new Bonus(BonusType.Teleportation));
        }

        public Bonus GenerateRandomBonus()
        {
            var index = random.Next(availableBonuses.Count);
            
            return availableBonuses[index];
        }

        public List<Bonus> GetAvailableBonuses()
        {
            return availableBonuses;
        }
    }
}