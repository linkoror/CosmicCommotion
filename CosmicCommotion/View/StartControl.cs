using System;
using System.Windows.Forms;
using CosmicCommotion.Model;

namespace CosmicCommotion
{
    public partial class StartControl : UserControl
    {
        private Game game;

        public StartControl()
        {
            InitializeComponent();
        }
        
        public void Configure(Game game)
        {
            if (this.game != null)
                return;

            this.game = game;
            
            startButton.Click += StartButton_Click;
            gameRulesButton.Click += GameRulesButton_Click;
        }
        
        private void StartButton_Click(object sender, EventArgs e)
        {
            game.Start();
        }
        
        private void GameRulesButton_Click(object sender, EventArgs e)
        {
            game.GameRules();
        }
    }
}