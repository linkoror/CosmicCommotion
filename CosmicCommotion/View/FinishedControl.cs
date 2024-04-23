using System.Windows.Forms;
using CosmicCommotion.Model;

namespace CosmicCommotion
{
    public partial class FinishedControl : UserControl
    {
        private Game game;

        public FinishedControl()
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