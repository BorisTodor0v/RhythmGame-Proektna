
namespace Rhythm_Game
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.perfectLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.goodLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.badLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.missLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.up = new System.Windows.Forms.PictureBox();
            this.down = new System.Windows.Forms.PictureBox();
            this.right = new System.Windows.Forms.PictureBox();
            this.left = new System.Windows.Forms.PictureBox();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfectLabel,
            this.goodLabel,
            this.badLabel,
            this.missLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 835);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // perfectLabel
            // 
            this.perfectLabel.Name = "perfectLabel";
            this.perfectLabel.Size = new System.Drawing.Size(78, 17);
            this.perfectLabel.Text = "Совршени: 0";
            // 
            // goodLabel
            // 
            this.goodLabel.Name = "goodLabel";
            this.goodLabel.Size = new System.Drawing.Size(55, 17);
            this.goodLabel.Text = "Добри: 0";
            // 
            // badLabel
            // 
            this.badLabel.Name = "badLabel";
            this.badLabel.Size = new System.Drawing.Size(52, 17);
            this.badLabel.Text = "Лоши: 0";
            // 
            // missLabel
            // 
            this.missLabel.Name = "missLabel";
            this.missLabel.Size = new System.Drawing.Size(88, 17);
            this.missLabel.Text = "Промашени: 0";
            // 
            // up
            // 
            this.up.Image = global::Rhythm_Game.Properties.Resources.up;
            this.up.Location = new System.Drawing.Point(236, 680);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(150, 150);
            this.up.TabIndex = 6;
            this.up.TabStop = false;
            // 
            // down
            // 
            this.down.Image = global::Rhythm_Game.Properties.Resources.down;
            this.down.Location = new System.Drawing.Point(392, 680);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(150, 150);
            this.down.TabIndex = 7;
            this.down.TabStop = false;
            // 
            // right
            // 
            this.right.Image = global::Rhythm_Game.Properties.Resources.right;
            this.right.Location = new System.Drawing.Point(548, 680);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(150, 150);
            this.right.TabIndex = 8;
            this.right.TabStop = false;
            // 
            // left
            // 
            this.left.Image = global::Rhythm_Game.Properties.Resources.left;
            this.left.Location = new System.Drawing.Point(80, 680);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(150, 150);
            this.left.TabIndex = 9;
            this.left.TabStop = false;
            // 
            // moveTimer
            // 
            this.moveTimer.Interval = 20;
            this.moveTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 857);
            this.Controls.Add(this.up);
            this.Controls.Add(this.down);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Ритамска игра";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox up;
        private System.Windows.Forms.PictureBox down;
        private System.Windows.Forms.PictureBox right;
        private System.Windows.Forms.PictureBox left;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.ToolStripStatusLabel perfectLabel;
        private System.Windows.Forms.ToolStripStatusLabel goodLabel;
        private System.Windows.Forms.ToolStripStatusLabel badLabel;
        private System.Windows.Forms.ToolStripStatusLabel missLabel;
    }
}