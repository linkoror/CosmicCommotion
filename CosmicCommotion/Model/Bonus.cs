namespace CosmicCommotion.Model
{
    public class Bonus
    {
        public int X { get; set; }
        public int Y { get; set; }
        public BonusType Type { get; }

        public Bonus(int x, int y, BonusType type)
        {
            X = x;
            Y = y;
            Type = type;
        }
        
        public Bonus(BonusType type)
        {
            Type = type;
        }

        public void Activate(SpaceShip ship)
        {
            switch (Type)
            {
                case BonusType.SpeedBoost:
                    ActivateSpeedBoost(ship);
                    break;
                case BonusType.StarMagnet:
                    ActivateStarMagnet(ship);
                    break;
                case BonusType.DamageBoost:
                    ActivateDamageBoost(ship);
                    break;
                case BonusType.ShieldRecharge:
                    ActivateShieldRecharge(ship);
                    break;
                case BonusType.TimeFreeze:
                    ActivateTimeFreeze(ship);
                    break;
                case BonusType.WeaponUpgrade:
                    ActivateWeaponUpgrade(ship);
                    break;
                case BonusType.Teleportation:
                    ActivateTeleportation(ship);
                    break;
                default:
                    break;
            }
        }

        private void ActivateSpeedBoost(SpaceShip ship)
        {
            ship.Speed *= 2;
        }

        private void ActivateStarMagnet(SpaceShip ship)
        {
            ship.IsStarMagnetActive = true;
        }

        private void ActivateDamageBoost(SpaceShip ship)
        {
            ship.WeaponDamage *= 2;
        }

        private void ActivateShieldRecharge(SpaceShip ship)
        {
            ship.RechargeShield();
        }

        private void ActivateTimeFreeze(SpaceShip ship)
        {
            ship.ActivateTimeFreeze();
        }

        private void ActivateWeaponUpgrade(SpaceShip ship)
        {
            ship.UpgradeWeapon();
        }

        private void ActivateTeleportation(SpaceShip ship)
        {
            ship.TeleportRandomly();
        }
    }
    
    public enum BonusType
    {
        SpeedBoost,
        StarMagnet,
        DamageBoost,
        ShieldRecharge,
        TimeFreeze,
        WeaponUpgrade,
        Teleportation
    }
}