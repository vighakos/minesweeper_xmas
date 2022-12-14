
namespace minesweeper_xmas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.szeles_lbl = new System.Windows.Forms.Label();
            this.magas_lbl = new System.Windows.Forms.Label();
            this.bomba_lbl = new System.Windows.Forms.Label();
            this.widthNum = new System.Windows.Forms.NumericUpDown();
            this.heightNum = new System.Windows.Forms.NumericUpDown();
            this.mineNum = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.widthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mineNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // szeles_lbl
            // 
            this.szeles_lbl.AutoSize = true;
            this.szeles_lbl.BackColor = System.Drawing.Color.Transparent;
            this.szeles_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szeles_lbl.ForeColor = System.Drawing.Color.Black;
            this.szeles_lbl.Location = new System.Drawing.Point(142, 122);
            this.szeles_lbl.Name = "szeles_lbl";
            this.szeles_lbl.Size = new System.Drawing.Size(139, 20);
            this.szeles_lbl.TabIndex = 0;
            this.szeles_lbl.Text = "Pálya szélessége: ";
            // 
            // magas_lbl
            // 
            this.magas_lbl.AutoSize = true;
            this.magas_lbl.BackColor = System.Drawing.Color.Transparent;
            this.magas_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.magas_lbl.ForeColor = System.Drawing.Color.Black;
            this.magas_lbl.Location = new System.Drawing.Point(142, 95);
            this.magas_lbl.Name = "magas_lbl";
            this.magas_lbl.Size = new System.Drawing.Size(142, 20);
            this.magas_lbl.TabIndex = 1;
            this.magas_lbl.Text = "Pálya magassága: ";
            // 
            // bomba_lbl
            // 
            this.bomba_lbl.AutoSize = true;
            this.bomba_lbl.BackColor = System.Drawing.Color.Transparent;
            this.bomba_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bomba_lbl.ForeColor = System.Drawing.Color.Black;
            this.bomba_lbl.Location = new System.Drawing.Point(142, 147);
            this.bomba_lbl.Name = "bomba_lbl";
            this.bomba_lbl.Size = new System.Drawing.Size(124, 20);
            this.bomba_lbl.TabIndex = 2;
            this.bomba_lbl.Text = "Télapók száma: ";
            // 
            // widthNum
            // 
            this.widthNum.Location = new System.Drawing.Point(288, 121);
            this.widthNum.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.widthNum.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.widthNum.Name = "widthNum";
            this.widthNum.Size = new System.Drawing.Size(95, 20);
            this.widthNum.TabIndex = 3;
            this.widthNum.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // heightNum
            // 
            this.heightNum.Location = new System.Drawing.Point(288, 95);
            this.heightNum.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.heightNum.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.heightNum.Name = "heightNum";
            this.heightNum.Size = new System.Drawing.Size(95, 20);
            this.heightNum.TabIndex = 4;
            this.heightNum.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // mineNum
            // 
            this.mineNum.Location = new System.Drawing.Point(288, 147);
            this.mineNum.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.mineNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mineNum.Name = "mineNum";
            this.mineNum.Size = new System.Drawing.Size(95, 20);
            this.mineNum.TabIndex = 5;
            this.mineNum.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "Custom";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Beginner";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(227, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Intermediate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(308, 182);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Expert";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(599, 370);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 369);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mineNum);
            this.Controls.Add(this.heightNum);
            this.Controls.Add(this.widthNum);
            this.Controls.Add(this.bomba_lbl);
            this.Controls.Add(this.magas_lbl);
            this.Controls.Add(this.szeles_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(612, 408);
            this.MinimumSize = new System.Drawing.Size(612, 408);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Santasweeper";
            ((System.ComponentModel.ISupportInitialize)(this.widthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mineNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label szeles_lbl;
        private System.Windows.Forms.Label magas_lbl;
        private System.Windows.Forms.Label bomba_lbl;
        private System.Windows.Forms.NumericUpDown widthNum;
        private System.Windows.Forms.NumericUpDown heightNum;
        private System.Windows.Forms.NumericUpDown mineNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

