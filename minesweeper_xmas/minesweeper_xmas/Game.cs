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

            GAME_WIDTH = width;
            GAME_HEIGHT = height;
            MINES = mines;
            Setup();
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
        }
        
        private void Timer1_Tick(object sender, EventArgs e)
        {
            int tp = 0;
            int mp = 0;
            int perc = 0;
            int ora = 0;
            tp++;

            if (tp == 1000)
            {
                tp = 0;
                mp = 1;
            }
            if (mp == 60)
            {
                mp = 0;
                perc = 1;
            }
            if (perc == 60)
            {
                perc = 0;
                ora = 1;
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
