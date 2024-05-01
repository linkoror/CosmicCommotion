using System;
using System.Windows.Forms;

public class SpaceShip
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Speed { get; set; }
    public int Health { get; set; }
    public bool IsShieldActive { get; private set; }
    private Timer shieldTimer;
    public int Score { get; set; }
    public int Level { get; private set; }
    public bool IsDestroyed { get; private set; }
    public int Size { get; private set; }
    public bool IsStarMagnetActive { get; set; }
    public int WeaponDamage { get; set; }

    public SpaceShip(int x, int y, int speed, int health)
    {
        X = x;
        Y = y;
        Speed = speed;
        Health = health;
        IsShieldActive = false;
        Level = 1;
        IsDestroyed = false;
        shieldTimer = new Timer();
        shieldTimer.Interval = 1000;
        shieldTimer.Tick += new EventHandler(ShieldTimer_Tick);
    }

    public void MoveUp()
    {
        Y -= Speed;
    }

    public void ActivateShield()
    {
        if (!IsShieldActive)
        {
            IsShieldActive = true;
            shieldTimer.Start();
        }
    }

    private void ShieldTimer_Tick(object sender, EventArgs e)
    {
        IsShieldActive = false;
        shieldTimer.Stop();
    }

    public void Update()
    {
        if (IsShieldActive)
        {
            
        }
    }

    public void Repair()
    {
        Health = 100;
    }

    public void CollectStar()
    {
        Score += 100;
        if (Score >= 500)
        {
            Level++;
            Score = 0;
        }
    }
    
    public void ApplyDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Destroy();
        }
    }

    private void Destroy()
    {
        IsDestroyed = true;
    }

    public bool CheckCollision(SpaceShip otherShip)
    {
        return X == otherShip.X && Y == otherShip.Y;
    }

    public bool CheckOutOfBounds(int maxX, int maxY)
    {
        return X < 0 || X >= maxX || Y < 0 || Y >= maxY;
    }
    
    public void TakeDamage(int damage)
    {
        Size -= damage;
        if (Size <= 0)
        {
            Destroy();
        }
    }

    public void TeleportRandomly()
    {
        throw new NotImplementedException();
    }

    public void UpgradeWeapon()
    {
        throw new NotImplementedException();
    }

    public void ActivateTimeFreeze()
    {
        throw new NotImplementedException();
    }

    public void RechargeShield()
    {
        throw new NotImplementedException();
    }
}
