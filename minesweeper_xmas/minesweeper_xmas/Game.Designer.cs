
namespace minesweeper_xmas
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
            this.restartBtn = new System.Windows.Forms.Button();
            this.mineCountLbl = new System.Windows.Forms.Label();
            this.minLbl = new System.Windows.Forms.Label();
            this.kettospotty = new System.Windows.Forms.Label();
            this.secLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // restartBtn
            // 
            this.restartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.restartBtn.Location = new System.Drawing.Point(94, 14);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(36, 36);
            this.restartBtn.TabIndex = 3;
            this.restartBtn.Text = "😎";
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // mineCountLbl
            // 
            this.mineCountLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mineCountLbl.Location = new System.Drawing.Point(30, 15);
            this.mineCountLbl.Name = "mineCountLbl";
            this.mineCountLbl.Size = new System.Drawing.Size(50, 35);
            this.mineCountLbl.TabIndex = 4;
            this.mineCountLbl.Text = "00";
            this.mineCountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minLbl
            // 
            this.minLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minLbl.Location = new System.Drawing.Point(148, 15);
            this.minLbl.Name = "minLbl";
            this.minLbl.Size = new System.Drawing.Size(35, 35);
            this.minLbl.TabIndex = 0;
            this.minLbl.Text = "00";
            this.minLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // kettospotty
            // 
            this.kettospotty.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kettospotty.Location = new System.Drawing.Point(178, 20);
            this.kettospotty.Name = "kettospotty";
            this.kettospotty.Size = new System.Drawing.Size(12, 20);
            this.kettospotty.TabIndex = 1;
            this.kettospotty.Text = ":";
            this.kettospotty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // secLbl
            // 
            this.secLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secLbl.Location = new System.Drawing.Point(185, 15);
            this.secLbl.Name = "secLbl";
            this.secLbl.Size = new System.Drawing.Size(35, 35);
            this.secLbl.TabIndex = 2;
            this.secLbl.Text = "00";
            this.secLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(244, 415);
            this.Controls.Add(this.mineCountLbl);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.secLbl);
            this.Controls.Add(this.kettospotty);
            this.Controls.Add(this.minLbl);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Label mineCountLbl;
        private System.Windows.Forms.Label minLbl;
        private System.Windows.Forms.Label kettospotty;
        private System.Windows.Forms.Label secLbl;
        private System.Windows.Forms.Timer timer1;
    }
}