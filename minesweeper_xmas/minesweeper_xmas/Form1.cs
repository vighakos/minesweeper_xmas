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
            if (mineNum.Value > widthNum.Value * heightNum.Value)
            {
                mineNum.Value = Convert.ToInt32(widthNum.Value * heightNum.Value / 4);
            }
            new Game(Convert.ToInt32(widthNum.Value), Convert.ToInt32(heightNum.Value), Convert.ToInt32(mineNum.Value)).ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            widthNum.Value = 8;
            heightNum.Value = 8;
            mineNum.Value = 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            widthNum.Value = 16;
            heightNum.Value = 16;
            mineNum.Value = 40;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            widthNum.Value = 30;
            heightNum.Value = 16;
            mineNum.Value = 99;
        }
    }
}
