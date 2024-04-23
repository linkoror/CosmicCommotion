using System.Windows.Forms;
using CosmicCommotion.Model;

namespace CosmicCommotion
{
    public partial class GameControl : UserControl
    {
        private Game game;

        public GameControl()
        {
            InitializeComponent();
        }
        
        public void Configure(Game game)
        {
            if (this.game != null)
                return;

            this.game = game;
        }
    }
}