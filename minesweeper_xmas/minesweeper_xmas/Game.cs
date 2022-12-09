using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace minesweeper_xmas
{
    public partial class Game : Form
    {

        int m, s;
        static int GAME_WIDTH, GAME_HEIGHT, MINES;
        static Cella[,] cellak;
        public Game(int width, int height, int mines)
        {
            InitializeComponent();
            GAME_WIDTH = width;
            GAME_HEIGHT = height;
            MINES = mines;
            Setup();
        }

        private void Game_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Setup()
        {
            #region Form beállítás

            this.BackColor = Color.FromArgb(192, 192, 192);
            this.Size = new Size(75 + GAME_WIDTH * 21, 150 + GAME_HEIGHT * 21);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            restartBtn.Location = new Point(GAME_WIDTH * 21 / 2 + 12, 15);
            minLbl.Location = new Point(GAME_WIDTH * 21 - 30, 15);
            kettospotty.Location = new Point(minLbl.Location.X + 30, 20);
            secLbl.Location = new Point(minLbl.Location.X + 37, 15);

            mineCountLbl.Text = MINES.ToString();

            #endregion

            cellak = new Cella[GAME_HEIGHT, GAME_WIDTH];

            for (int sor = 0; sor < GAME_HEIGHT; sor++)
            {
                for (int oszlop = 0; oszlop < GAME_WIDTH; oszlop++)
                {
                    Label uj = new Label()
                    {
                        Location = new Point(30 + oszlop * 21, 70 + sor * 21),
                        Size = new Size(20, 20),
                        Name = $"{sor}_{oszlop}",
                        Text = $"{sor}_{oszlop}",
                        BackColor = Color.DarkGray
                    };
                    cellak[sor, oszlop] = new Cella(sor, oszlop, false, uj);

                    this.Controls.Add(uj);
                }
            }
            timer1.Start();
        }
        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            Application.DoEvents();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
