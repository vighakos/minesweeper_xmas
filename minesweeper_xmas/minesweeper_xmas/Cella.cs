using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace minesweeper_xmas
{
    class Cella
    {
        public Label Lbl;
        public bool Revealed, IsMine, Flagged;
        public int X, Y;

        public Cella(int x, int y, Label lbl)
        {
            Lbl = lbl;
            Revealed = false;
            X = x;
            Y = y;
            IsMine = false;
            Flagged = false;
        }
    }
}
