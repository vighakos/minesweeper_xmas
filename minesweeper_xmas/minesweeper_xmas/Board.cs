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

            for (int sor = 0; sor < Height; sor++)
            {
                for (int oszlop = 0; oszlop < Width; oszlop++)
                {
                    // TODO: pálya generálás adott számó aknával
                }
            }

            return Map;
        }

        public int GetMines(int koord_x, int koord_y)
        {
            int count = 0;

            // TODO: visszaadja hány aknát érint a cella

            return count;
        }
    }
}
