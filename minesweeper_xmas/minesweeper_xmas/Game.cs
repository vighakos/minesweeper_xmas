﻿using System;
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
    public partial class Game : Form
    {
        static int MINES, GAME_WIDTH, GAME_HEIGHT;
        public Game(int width, int height, int mines)
        {
            InitializeComponent();
            MINES = mines;
            GAME_WIDTH = width;
            GAME_HEIGHT = height;
            Setup();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Setup()
        {
            this.BackColor = Color.FromArgb(192, 192, 192);

        }
        
        private void Timer1_Tick(object sender, EventArgs e)
        {

            int mp = 0;
            int perc = 0;
            int ora = 0;
        }
    }
}
