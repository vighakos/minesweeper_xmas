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
        static int GAME_WIDTH, GAME_HEIGHT, MINES;
        static Cella[,] cellak;
        public Game(int width, int height, int mines)
        {
            InitializeComponent();
            MINES = mines;
            GAME_WIDTH = width;
            GAME_HEIGHT = height;
            Setup();
        }

        private void Setup()
        {
            this.BackColor = Color.FromArgb(192, 192, 192);
            cellak = new Cella[GAME_HEIGHT, GAME_WIDTH];

            for (int i = 0; i < GAME_HEIGHT; i++)
            {
                for (int j = 0; j < GAME_WIDTH; j++)
                {
                    PictureBox uj = new PictureBox()
                    {
                        Location = new Point(50 + j * 21, 90 + i * 21),
                        Size = new Size(20, 20),
                        Name = $"{i}_{j}",
                        BackColor = Color.Gray,
                        SizeMode = PictureBoxSizeMode.CenterImage
                    };
                    cellak[i, j] = new Cella(i, j, false, uj);

                    Controls.Add(uj);
                }
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
