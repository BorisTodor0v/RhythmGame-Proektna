
namespace Rhythm_Game
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.start = new System.Windows.Forms.Button();
            this.scoreboard = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.highscore = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(151, 273);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(144, 48);
            this.start.TabIndex = 6;
            this.start.TabStop = false;
            this.start.Text = "Започни";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // scoreboard
            // 
            this.scoreboard.FormattingEnabled = true;
            this.scoreboard.ItemHeight = 15;
            this.scoreboard.Location = new System.Drawing.Point(114, 355);
            this.scoreboard.Name = "scoreboard";
            this.scoreboard.Size = new System.Drawing.Size(207, 184);
            this.scoreboard.TabIndex = 7;
            this.scoreboard.TabStop = false;
            this.scoreboard.SelectedIndexChanged += new System.EventHandler(this.scoreboard_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(114, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Претходни резултати";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(114, 539);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Најдобар резултат";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highscore
            // 
            this.highscore.Location = new System.Drawing.Point(114, 571);
            this.highscore.Name = "highscore";
            this.highscore.ReadOnly = true;
            this.highscore.Size = new System.Drawing.Size(207, 23);
            this.highscore.TabIndex = 10;
            this.highscore.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rhythm_Game.Properties.Resources.imageedit_1_8321638479;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 237);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 615);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.highscore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreboard);
            this.Controls.Add(this.start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Ритамска игра";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.ListBox scoreboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox highscore;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

