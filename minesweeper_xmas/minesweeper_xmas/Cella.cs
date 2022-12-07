using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minesweeper_xmas
{
    class Cella
    {
        public PictureBox Pbox;
        public bool Revealed;
        public bool Mine;
        public int X, Y;

        public Cella(int x, int y, bool mine)
        {
            // TODO: Pbox
            Revealed = false;
            Mine = mine;
            X = x;
            Y = y;
        }
    }
}
