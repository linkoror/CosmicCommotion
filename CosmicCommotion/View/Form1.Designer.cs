namespace CosmicCommotion
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startControl = new CosmicCommotion.StartControl();
            this.rulesGameControl = new CosmicCommotion.RulesGameControl();
            this.gameControl = new CosmicCommotion.GameControl();
            this.finishedControl = new CosmicCommotion.FinishedControl();
            this.SuspendLayout();
            // 
            // startControl
            // 
            this.startControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startControl.Location = new System.Drawing.Point(0, 0);
            this.startControl.Name = "startControl";
            this.startControl.Size = new System.Drawing.Size(800, 600);
            this.startControl.TabIndex = 2;
            // 
            // rulesGameControl
            // 
            this.rulesGameControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rulesGameControl.Location = new System.Drawing.Point(0, 0);
            this.rulesGameControl.Name = "rulesGameControl";
            this.rulesGameControl.Size = new System.Drawing.Size(800, 600);
            this.rulesGameControl.TabIndex = 1;
            // 
            // gameControl
            // 
            this.gameControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameControl.Location = new System.Drawing.Point(0, 0);
            this.gameControl.Name = "gameControl";
            this.gameControl.Size = new System.Drawing.Size(800, 600);
            this.gameControl.TabIndex = 0;
            // 
            // finishedControl
            // 
            this.finishedControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finishedControl.Location = new System.Drawing.Point(0, 0);
            this.finishedControl.Name = "finishedControl";
            this.finishedControl.Size = new System.Drawing.Size(800, 600);
            this.finishedControl.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.startControl);
            this.Controls.Add(this.rulesGameControl);
            this.Controls.Add(this.gameControl);
            this.Controls.Add(this.finishedControl);
            this.MaximumSize = new System.Drawing.Size(816, 639);
            this.MinimumSize = new System.Drawing.Size(816, 639);
            this.Text = "Космический переполох";
            this.ResumeLayout(false);
        }

        #endregion
        
        
        private StartControl startControl;
        private RulesGameControl rulesGameControl;
        private GameControl gameControl;
        private FinishedControl finishedControl;
    }
}