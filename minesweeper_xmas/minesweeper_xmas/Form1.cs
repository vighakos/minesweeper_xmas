using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minesweeper_xmas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Game(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value)).ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 8;
            numericUpDown2.Value = 8;
            numericUpDown3.Value = 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 16;
            numericUpDown2.Value = 16;
            numericUpDown3.Value = 40;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 30;
            numericUpDown2.Value = 16;
            numericUpDown3.Value = 99;
        }
    }
}
