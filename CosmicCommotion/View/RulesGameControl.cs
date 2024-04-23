using System.Windows.Forms;
using CosmicCommotion.Model;

namespace CosmicCommotion
{
    public partial class RulesGameControl : UserControl
    {
        private Game game;

        public RulesGameControl()
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