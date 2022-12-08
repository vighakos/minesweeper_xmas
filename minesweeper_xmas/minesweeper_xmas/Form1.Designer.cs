
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
            this.SuspendLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.szeles_lbl = new System.Windows.Forms.Label();
            this.magas_lbl = new System.Windows.Forms.Label();
            this.bomba_lbl = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // szeles_lbl
            // 
            this.szeles_lbl.AutoSize = true;
            this.szeles_lbl.BackColor = System.Drawing.Color.Transparent;
            this.szeles_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szeles_lbl.ForeColor = System.Drawing.Color.White;
            this.szeles_lbl.Location = new System.Drawing.Point(142, 96);
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
            this.magas_lbl.ForeColor = System.Drawing.Color.White;
            this.magas_lbl.Location = new System.Drawing.Point(142, 122);
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
            this.bomba_lbl.ForeColor = System.Drawing.Color.White;
            this.bomba_lbl.Location = new System.Drawing.Point(142, 147);
            this.bomba_lbl.Name = "bomba_lbl";
            this.bomba_lbl.Size = new System.Drawing.Size(124, 20);
            this.bomba_lbl.TabIndex = 2;
            this.bomba_lbl.Text = "Télapók száma: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(288, 95);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(59, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(288, 122);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(59, 20);
            this.numericUpDown2.TabIndex = 4;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(288, 147);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(59, 20);
            this.numericUpDown3.TabIndex = 5;
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.ClientSize = new System.Drawing.Size(596, 369);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.bomba_lbl);
            this.Controls.Add(this.magas_lbl);
            this.Controls.Add(this.szeles_lbl);
            this.MaximumSize = new System.Drawing.Size(612, 408);
            this.MinimumSize = new System.Drawing.Size(612, 408);
            this.Name = "Form1";
            this.Text = "Santasweeper";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label szeles_lbl;
        private System.Windows.Forms.Label magas_lbl;
        private System.Windows.Forms.Label bomba_lbl;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
    }
}

