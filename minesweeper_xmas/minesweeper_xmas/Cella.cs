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
        public PictureBox Pbox;
        public bool Revealed;
        public bool IsMine;
        public int X, Y;

        public Cella(int x, int y, bool mine, PictureBox pbox)
        {
            Pbox = pbox;
            Revealed = false;
            IsMine = mine;
            X = x;
            Y = y;
        }
    }
}
