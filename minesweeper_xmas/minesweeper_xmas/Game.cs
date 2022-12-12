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
        int m, s;
        static int GAME_WIDTH, GAME_HEIGHT, MINES;
        static Cella[,] cellak;
        static Board board;
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
            FormSetup();
            BoardSetup();
        }

        private void FormSetup()
        {
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
        }

        private void BoardSetup()
        {
            board = new Board(GAME_WIDTH, GAME_HEIGHT, MINES);

            cellak = new Cella[GAME_HEIGHT, GAME_WIDTH];
            Font font = new Font(this.Font, FontStyle.Bold);
            Size size = new Size(20, 20);

            for (int sor = 0; sor < GAME_HEIGHT; sor++)
            {
                for (int oszlop = 0; oszlop < GAME_WIDTH; oszlop++)
                {
                    Label uj = new Label()
                    {
                        Location = new Point(30 + oszlop * 21, 70 + sor * 21),
                        Size = size,
                        Name = $"{sor}_{oszlop}",
                        BackColor = Color.DarkGray,
                        Font = font,
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    cellak[sor, oszlop] = new Cella(sor, oszlop, uj);
                    uj.Click += new EventHandler(Lbl_Click);
                    this.Controls.Add(uj);
                }
            }
        }

        private void Lbl_Click(object sender, EventArgs e)
        {
            Label item = (Label)sender;
            int koord_x = Convert.ToInt32(item.Name.Split('_')[0]);
            int koord_y = Convert.ToInt32(item.Name.Split('_')[1]);

            if (board.Map == null)
            {
                board.GenerateMap(koord_x, koord_y);

                for (int sor = 0; sor < GAME_HEIGHT; sor++)
                    for (int oszlop = 0; oszlop < GAME_WIDTH; oszlop++)
                    {
                        cellak[sor, oszlop].IsMine = board.Map[sor, oszlop] == 1;
                        if (cellak[sor, oszlop].IsMine) cellak[sor, oszlop].Lbl.BackColor = Color.Red;
                    }
            }

            if (cellak[koord_x, koord_y].IsMine)
            {
                item.BackColor = Color.Red;
                Lose();
            }

            item.BackColor = Color.White;
            int count = board.GetMines(koord_x, koord_y);
            item.Text = count == 0 ? "" : count.ToString();
        }

        private void Lose()
        {
            if (MessageBox.Show("Szeretnél újat kezdeni?", "Vesztettél", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Restart();
            else Application.Exit();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
            }
            ));
            minLbl.Text = m.ToString();
            secLbl.Text = s.ToString();
        }

        private void Button1_Click(object sender, EventArgs e) { timer1.Stop(); Application.Restart();  }

        private void Game_FormClosing(object sender, FormClosingEventArgs e) { timer1.Stop(); Application.Exit(); }
    }
}
