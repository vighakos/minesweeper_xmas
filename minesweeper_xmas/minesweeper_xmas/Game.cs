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

            switch (mousevent.Button)
            {
                case MouseButtons.Left:
                    {
                        if (cella.Flagged || cella.Revealed) return;
                        if (cella.IsMine)
                        {
                            //TODO: összes akna mutatása vesztésnél
                            item.BackColor = Color.Red;
                            item.Text = "💣";
                            Lose();
                        }

                        int count = board.GetMines(koord_x, koord_y);
                        item.BackColor = Color.White;
                        item.Text = count == 0 ? "" : count.ToString();
                        cella.Revealed = true;

                        if (count == 0) RevealTiles(koord_x, koord_y);

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

                        if (cella.Revealed) return;
                        if (!cella.Flagged)
                        {
                            board.Map[koord_x, koord_y] = board.Map[koord_x, koord_y] == 1 ? 2 : 3;
                            cella.Flagged = true;
                            item.Text = "⚑";
                        }
                        else
                        {
                            board.Map[koord_x, koord_y] = board.Map[koord_x, koord_y] == 2 ? 1 : 0;
                            cella.Flagged = false;
                            item.Text = "";
                        }
                        break;
                    }
                default:
                    break;
            }
        }

        private void RevealTiles(int x, int y)
        {
            Cella cella = cellak[x, y];
            if (x < 0 || x > GAME_HEIGHT || y < 0 || y > GAME_WIDTH || cella.Revealed) return;

            if (cella.IsMine && !cella.Flagged)
            {
                cella.Lbl.BackColor = Color.Red;
                cella.Lbl.Text = "¤";
                Lose();
            }

            int count = board.GetMines(x, y);
            cella.Revealed = true;
            cella.Lbl.BackColor = Color.White;
            cella.Lbl.Text = count == 0 ? "" : count.ToString();

            if (count == 0)
            {
                RevealTiles(x, y + 1);
                RevealTiles(x, y - 1);
                RevealTiles(x + 1, y);
                RevealTiles(x - 1, y);
            }
        }

        private void Lose()
        {
            if (MessageBox.Show("Szeretnél újat kezdeni?", "Vesztettél", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Restart();
            else Application.Exit();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            s = 0;
            m = 0;

            s += 1;
            if (s == 60 )
            {
                s = 0;
                m += 1;
            }
            minLbl.Text = string.Format("{0}", m.ToString().PadLeft(2, '0'));
            secLbl.Text = string.Format("{0}", m.ToString().PadLeft(2, '0'));

        }

        private void Button1_Click(object sender, EventArgs e) { timer1.Stop(); Application.Restart(); }

        private void Game_FormClosing(object sender, FormClosingEventArgs e) { timer1.Stop(); Application.Exit(); }
    }
}
