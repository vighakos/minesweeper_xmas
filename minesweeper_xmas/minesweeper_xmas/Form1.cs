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
            this.Hide();
            if (mineNum.Value > widthNum.Value * heightNum.Value * Convert.ToDecimal(0.3))
            {
                mineNum.Value = Convert.ToInt32(widthNum.Value * heightNum.Value * Convert.ToDecimal(0.3));
            }
            new Game(Convert.ToInt32(widthNum.Value), Convert.ToInt32(heightNum.Value), Convert.ToInt32(mineNum.Value)).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Game(8, 8, 10).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Game(16, 16, 40).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Game(30, 16, 99).Show();
        }
    }
}
