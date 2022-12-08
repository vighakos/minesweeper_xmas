
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.minLbl = new System.Windows.Forms.Label();
            this.kettospotty = new System.Windows.Forms.Label();
            this.secLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mineCountLbl = new System.Windows.Forms.Label();
            this.hLbl = new System.Windows.Forms.Label();
            this.percLbl = new System.Windows.Forms.Label();
            this.mpLbl = new System.Windows.Forms.Label();
            this.tpLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // minLbl
            // 
            this.minLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minLbl.Location = new System.Drawing.Point(244, 9);
            this.minLbl.Name = "minLbl";
            this.minLbl.Size = new System.Drawing.Size(33, 58);
            this.minLbl.TabIndex = 0;
            this.minLbl.Text = "00";
            this.minLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // kettospotty
            // 
            this.kettospotty.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kettospotty.Location = new System.Drawing.Point(273, 9);
            this.kettospotty.Name = "kettospotty";
            this.kettospotty.Size = new System.Drawing.Size(14, 58);
            this.kettospotty.TabIndex = 1;
            this.kettospotty.Text = ":";
            this.kettospotty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secLbl
            // 
            this.secLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secLbl.Location = new System.Drawing.Point(283, 9);
            this.secLbl.Name = "secLbl";
            this.secLbl.Size = new System.Drawing.Size(29, 58);
            this.secLbl.TabIndex = 2;
            this.secLbl.Text = "00";
            this.secLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(138, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "😎";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // mineCountLbl
            // 
            this.mineCountLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mineCountLbl.Location = new System.Drawing.Point(12, 9);
            this.mineCountLbl.Name = "mineCountLbl";
            this.mineCountLbl.Size = new System.Drawing.Size(52, 58);
            this.mineCountLbl.TabIndex = 4;
            this.mineCountLbl.Text = "00";
            this.mineCountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hLbl
            // 
            this.hLbl.AutoSize = true;
            this.hLbl.Location = new System.Drawing.Point(29, 315);
            this.hLbl.Name = "hLbl";
            this.hLbl.Size = new System.Drawing.Size(10, 13);
            this.hLbl.TabIndex = 5;
            this.hLbl.Text = ".";
            // 
            // percLbl
            // 
            this.percLbl.AutoSize = true;
            this.percLbl.Location = new System.Drawing.Point(54, 315);
            this.percLbl.Name = "percLbl";
            this.percLbl.Size = new System.Drawing.Size(10, 13);
            this.percLbl.TabIndex = 6;
            this.percLbl.Text = ".";
            // 
            // mpLbl
            // 
            this.mpLbl.AutoSize = true;
            this.mpLbl.Location = new System.Drawing.Point(81, 315);
            this.mpLbl.Name = "mpLbl";
            this.mpLbl.Size = new System.Drawing.Size(10, 13);
            this.mpLbl.TabIndex = 7;
            this.mpLbl.Text = ".";
            // 
            // tpLbl
            // 
            this.tpLbl.AutoSize = true;
            this.tpLbl.Location = new System.Drawing.Point(107, 315);
            this.tpLbl.Name = "tpLbl";
            this.tpLbl.Size = new System.Drawing.Size(10, 13);
            this.tpLbl.TabIndex = 8;
            this.tpLbl.Text = ".";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.tpLbl);
            this.Controls.Add(this.mpLbl);
            this.Controls.Add(this.percLbl);
            this.Controls.Add(this.hLbl);
            this.Controls.Add(this.mineCountLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.secLbl);
            this.Controls.Add(this.kettospotty);
            this.Controls.Add(this.minLbl);
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label minLbl;
        private System.Windows.Forms.Label kettospotty;
        private System.Windows.Forms.Label secLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label mineCountLbl;
        private System.Windows.Forms.Label hLbl;
        private System.Windows.Forms.Label percLbl;
        private System.Windows.Forms.Label mpLbl;
        private System.Windows.Forms.Label tpLbl;
    }
}