using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CosmicCommotion.Model;

namespace CosmicCommotion
{
    public partial class Form1 : Form
    {
        private Game game;

        public Form1()
        {
            InitializeComponent();
            
            game = new Game();
            game.StageChanged += Game_OnStageChanged;

            ShowStartScreen();
        }
        
        private void Game_OnStageChanged(GameStation stage)
        {
            switch (stage)
            {
                case GameStation.GameRules:
                    ShowRulesGameScreen();
                    break;
                case GameStation.Game:
                    ShowGameScreen();
                    break;
                case GameStation.Finished:
                    ShowFinishedScreen();
                    break;
                case GameStation.NotStarted:
                default:
                    ShowStartScreen();
                    break;
            }
        }
        
        private void ShowStartScreen()
        {
            HideScreens();
            startControl.Configure(game);
            startControl.Show();
        }

        private void ShowRulesGameScreen()
        {
            HideScreens();
            rulesGameControl.Configure(game);
            rulesGameControl.Show();
        }

        private void ShowGameScreen()
        {
            HideScreens();
            gameControl.Configure(game);
            gameControl.Show();
        }
        
        private void ShowFinishedScreen()
        {
            HideScreens();
            finishedControl.Configure(game);
            finishedControl.Show();
        }

        private void HideScreens()
        {
            startControl.Hide();
            rulesGameControl.Hide();
            gameControl.Hide();
            finishedControl.Hide();
        }
    }
}