using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minesweeper_xmas
{
    class Board
    {
        public int[,] Map;
        public int Width, Height, Mines;

        public Board(int width, int height, int mines)
        {
            Width = width;
            Height = height;
            Mines = mines;
            Map = null;
        }

        public void GenerateMap(int koord_x, int koord_y)
        {
            Map = new int[Height, Width];
            Random random = new Random();

            for (int i = 0; i < Mines; i++)
            {
                bool rakott = false;

                while (!rakott)
                {
                    int sor = random.Next(0, Height);
                    int oszlop = random.Next(0, Width);

                    if (Map[sor, oszlop] != 1 && sor != koord_x && oszlop != koord_y)
                    {
                        Map[sor, oszlop] = 1;
                        rakott = true;
                    }
                }
            }
        }

        public int GetMines(int x, int y)
        {
            int count = 0;

            for (int sor = x - 1; sor < x + 2; sor++)
                for (int oszlop = y - 1; oszlop < y + 2; oszlop++)
                {
                    if (sor == x && oszlop == y) continue;
                    if (sor < 0 || sor >= Height) continue;
                    if (oszlop < 0 || oszlop >= Width) continue;

                    if (Map[sor, oszlop] == 1 || Map[sor, oszlop] == 2) count++;
                }

            return count;
        }

        public int GetFlags(int x, int y)
        {
            int count = 0;

            for (int sor = x - 1; sor < x + 2; sor++)
                for (int oszlop = y - 1; oszlop < y + 2; oszlop++)
                {
                    if (sor == x && oszlop == y) continue;
                    if (sor < 0 || sor >= Height) continue;
                    if (oszlop < 0 || oszlop >= Width) continue;

                    if (Map[sor, oszlop] == 2 || Map[sor, oszlop] == 3) count++;
                }

            return count;
        }
    }
}
