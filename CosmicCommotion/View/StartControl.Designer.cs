using System.ComponentModel;

namespace CosmicCommotion
{
    partial class StartControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.gameRulesButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.startButton, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.gameRulesButton, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.pictureBox, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(860, 600);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::CosmicCommotion.Properties.Resources.MainBackground;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(233, 103);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(394, 394);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(330, 38);
            this.startButton.Margin = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(200, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Начать игру";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // gameRulesButton
            // 
            this.gameRulesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gameRulesButton.Location = new System.Drawing.Point(330, 528);
            this.gameRulesButton.Margin = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.gameRulesButton.Name = "gameRulesButton";
            this.gameRulesButton.Size = new System.Drawing.Size(200, 44);
            this.gameRulesButton.TabIndex = 2;
            this.gameRulesButton.Text = "Правила игры";
            this.gameRulesButton.UseVisualStyleBackColor = true;
            // 
            // StartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableLayoutPanel);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "StartControl";
            this.Size = new System.Drawing.Size(860, 600);
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button gameRulesButton;
    }
}