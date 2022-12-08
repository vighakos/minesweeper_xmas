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
    public partial class Game : Form
    {
<<<<<<< HEAD
        
        public Game()
        {
            InitializeComponent();
            int magassag = 0;
            int szelesseg = 0;
            int[,] matrix = new int[magassag,szelesseg];

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {

                }
            }
=======
        static int MINES, GAME_WIDTH, GAME_HEIGHT;

        public Game(int iWidth, int iHeight, int iMines)
        {
            InitializeComponent();
            MINES = iMines;
            GAME_WIDTH = iWidth;
            GAME_HEIGHT = iHeight;
            Setup();
        }

        private void Setup()
        {
            this.BackColor = Color.FromArgb(192, 192, 192);

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {

>>>>>>> f6fd390ad4617c68fa4cfb566e9b3a43b11804e2
        }
    }
}
