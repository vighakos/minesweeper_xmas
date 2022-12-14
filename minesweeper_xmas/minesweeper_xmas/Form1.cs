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
            magas_lbl.Visible = true;
            heightNum.Visible = true;
            szeles_lbl.Visible = true;
            widthNum.Visible = true;
            bomba_lbl.Visible = true;
            mineNum.Visible = true;
            //startBtn.Visible = true;
            button1.Visible = false;
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

        private void startBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (mineNum.Value > widthNum.Value * heightNum.Value)
            {
                mineNum.Value = Convert.ToInt32(widthNum.Value * heightNum.Value / 4);
            }
            new Game(Convert.ToInt32(widthNum.Value), Convert.ToInt32(heightNum.Value), Convert.ToInt32(mineNum.Value)).Show();
        }
    }
}
