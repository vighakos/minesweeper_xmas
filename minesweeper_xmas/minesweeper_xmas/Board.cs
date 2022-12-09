using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        public int[,] GenerateBoard()
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

                    if (Map[sor, oszlop] != 1)
                    {
                        Map[sor, oszlop] = 1;
                        rakott = true;
                    }
                }
            }

            return Map;
        }

        public int GetMines(int koord_x, int koord_y)
        {
            List<int> aknak = new List<int>();

            for (int sor = koord_x - 1; sor < koord_x + 1; sor++)
            {
                for (int oszlop = koord_y - 1; oszlop < koord_y + 1; oszlop++)
                {
                    if (sor < Width && sor > -1 && oszlop < Height && oszlop > -1)
                    {
                        aknak.Add(Map[sor, oszlop]);
                    }
                }
            }

            return aknak.Where(x => x == 1).Count();
        }
    }
}
