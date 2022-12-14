using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace minesweeper_xmas
{
    public partial class Game : Form
    {
        public int m = 0;
        public int s = 0;
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
                for (int oszlop = 0; oszlop < GAME_WIDTH; oszlop++)
                {
                    Label uj = new Label()
                    {
                        Location = new Point(30 + oszlop * 21, 70 + sor * 21),
                        Size = size,
                        Name = $"{sor}_{oszlop}",
                        Font = font,
                        AutoSize = false,
                        BackColor = Color.DarkGray,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    cellak[sor, oszlop] = new Cella(sor, oszlop, uj);
                    uj.Click += new EventHandler(Lbl_Click);
                    this.Controls.Add(uj);
                }
        }

        private void Lbl_Click(object sender, EventArgs e)
        {
            MouseEventArgs mousevent = (MouseEventArgs)e;

            Label item = (Label)sender;
            int koord_x = Convert.ToInt32(item.Name.Split('_')[0]);
            int koord_y = Convert.ToInt32(item.Name.Split('_')[1]);

            Cella cella = cellak[koord_x, koord_y];

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

            int count = board.GetMines(koord_x, koord_y);

            switch (mousevent.Button)
            {
                case MouseButtons.Left:
                    {
                        if (cella.Flagged) return;
                        if (cella.IsMine) Lose(koord_x, koord_y);

                        if (count == 0) RevealTiles(koord_x, koord_y);
                        else if (cella.Revealed) Chord(koord_x, koord_y);
                        else
                        {
                            cella.Revealed = true;
                            cella.Lbl.BackColor = Color.White;
                            cella.Lbl.Text = count == 0 ? "" : count.ToString();
                        }

                        break;
                    }

                case MouseButtons.Right:
                    {
                        /*
                         * 0: nincs akna, nincs zászlózva
                         * 1: akna van, nincs zászlózva
                         * 2: akna van, zászlózva van
                         * 3: nincs akna, zászlózva van
                        */
                        int minecount = Convert.ToInt32(mineCountLbl.Text);

                        if (cella.Revealed) return;
                        if (!cella.Flagged && minecount > 0) 
                        {
                            board.Map[koord_x, koord_y] = board.Map[koord_x, koord_y] == 1 ? 2 : 3;
                            cella.Flagged = true;
                            item.Text = "⚑";

                            minecount--;
                            mineCountLbl.Text = minecount.ToString();
                        }
                        else if (cella.Flagged)
                        {
                            board.Map[koord_x, koord_y] = board.Map[koord_x, koord_y] == 2 ? 1 : 0;
                            cella.Flagged = false;
                            item.Text = "";

                            minecount++;
                            mineCountLbl.Text = minecount.ToString();
                        }
                        break;
                    }

                default:
                    break;
            }

            WinCheck();
        }

        private void Chord(int x, int y)
        {
            if (board.GetMines(x, y) == board.GetFlags(x, y))
            {
                RevealTiles(x - 1, y);
                RevealTiles(x + 1, y);
                RevealTiles(x, y - 1);
                RevealTiles(x, y + 1);
                RevealTiles(x - 1, y - 1);
                RevealTiles(x - 1, y + 1);
                RevealTiles(x + 1, y + 1);
                RevealTiles(x + 1, y - 1);
            }
        }

        private void RevealTiles(int x, int y)
        {
            if (x < 0 || x >= GAME_HEIGHT || y < 0 || y >= GAME_WIDTH) return;
            Cella cella = cellak[x, y];

            if (cella.Revealed || cella.Flagged) return;
            if (cella.IsMine) Lose(x, y);

            int count = board.GetMines(x, y);

            cella.Revealed = true;
            cella.Lbl.BackColor = Color.White;
            cella.Lbl.Text = count == 0 ? "" : count.ToString();

            if (count == 0)
            {
                RevealTiles(x - 1, y);
                RevealTiles(x + 1, y);
                RevealTiles(x, y - 1);
                RevealTiles(x, y + 1);
                RevealTiles(x - 1, y - 1);
                RevealTiles(x - 1, y + 1);
                RevealTiles(x + 1, y + 1);
                RevealTiles(x + 1, y - 1);
            }
        }

        private void WinCheck()
        {
            int count = 0;
            for (int sor = 0; sor < GAME_HEIGHT; sor++)
            {
                for (int oszlop = 0; oszlop < GAME_WIDTH; oszlop++)
                {
                    if (board.Map[sor, oszlop] == 2) count++;
                }
            }

            if (count == MINES)
            {
                if (MessageBox.Show("Szeretnél újat játszani?", "Nyertél", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Application.Restart();
                else
                    Application.Exit();
            }
        }

        private void Lose(int x, int y)
        {
            for (int sor = 0; sor < GAME_HEIGHT; sor++)
                for (int oszlop = 0; oszlop < GAME_WIDTH; oszlop++)
                {
                    if (sor == x && oszlop == y)
                    {
                        cellak[sor, oszlop].Lbl.BackColor = Color.Red;
                        cellak[sor, oszlop].Lbl.Text = "💣";
                        continue;
                    }
                    if (board.Map[sor, oszlop] == 1)
                    {
                        cellak[sor, oszlop].Lbl.BackColor = Color.White;
                        cellak[sor, oszlop].Lbl.Text = "💣";
                    }
                    else if (board.Map[sor, oszlop] == 2) cellak[sor, oszlop].Lbl.BackColor = Color.Green;
                    else if (board.Map[sor, oszlop] == 3) cellak[sor, oszlop].Lbl.BackColor = Color.LightCoral;
                }

            if (MessageBox.Show($"Szeretnél újat kezdeni? [{x}, {y}]", "Vesztettél", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                Application.Restart();
            else 
                Application.Exit();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 100;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {   /* backup
            s++;
            if (s == 60)
            {
                s = 0;
                m += 1;
            }
            secLbl.Text = s.ToString();
            minLbl.Text = m.ToString();
            */

            s++;
            if (s == 60 )
            {
                s = 0;
                m += 1;
            }
            if (s < 10)
            {
                secLbl.Text = "0" + s.ToString();
            }
            if (s >= 10)
            {
                secLbl.Text = s.ToString();
            }
            if (m < 10)
            {
               minLbl.Text = "0" + m.ToString();
            }
            if (m >= 10)
            {
                minLbl.Text = m.ToString();
            }
        }

        private void Button1_Click(object sender, EventArgs e) { timer1.Stop(); Application.Restart(); }

        private void Game_FormClosing(object sender, FormClosingEventArgs e) { timer1.Stop(); Application.Exit(); }
    }
}
