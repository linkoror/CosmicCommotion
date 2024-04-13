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

    public SpaceShip(int x, int y, int speed, int health)
    {
        X = x;
        Y = y;
        Speed = speed;
        Health = health;
        IsShieldActive = false;
        Level = 1;
        IsDestroyed = false;
        // Создаем и настраиваем таймер для щита
        shieldTimer = new Timer();
        shieldTimer.Interval = 1000; // Интервал в миллисекундах (здесь 1 секунда)
        shieldTimer.Tick += new EventHandler(ShieldTimer_Tick); // Подключаем обработчик события Tick
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
            shieldTimer.Start(); // Запускаем таймер при активации щита
        }
    }

    private void ShieldTimer_Tick(object sender, EventArgs e)
    {
        IsShieldActive = false; // Выключаем щит по истечении времени таймера
        shieldTimer.Stop(); // Останавливаем таймер
    }

    public void Update()
    {
        if (IsShieldActive)
        {
            // Логика для активного щита
        }

        // Логика обновления состояния корабля
        // Например, проверка столкновений, перемещение или другие действия
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
        // Проверяем столкновение с другим кораблем по координатам
        return X == otherShip.X && Y == otherShip.Y;
    }

    public bool CheckOutOfBounds(int maxX, int maxY)
    {
        // Проверяем, находится ли корабль за пределами игрового поля
        return X < 0 || X >= maxX || Y < 0 || Y >= maxY;
    }
}
