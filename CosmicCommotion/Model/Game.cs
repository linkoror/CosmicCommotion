using System;

namespace CosmicCommotion.Model
{
    public class Game
    {
        private GameStation station = GameStation.NotStarted;
        public event Action<GameStation> StageChanged;
        
        public void Start()
        {
            ChangeStage(GameStation.Game);
        }
        
        public void GameRules()
        {
            ChangeStage(GameStation.GameRules);
        }
        
        private void ChangeStage(GameStation station)
        {
            this.station = station;
            StageChanged?.Invoke(station);
        }
    }
}