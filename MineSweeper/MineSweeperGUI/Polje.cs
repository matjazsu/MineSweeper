using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MineSweeperGUI
{
    public class Polje
    {
        public bool odkrit { get; set; }
        public bool bomba { get; set; }
        public string stevilo { get; set; }
        public System.Windows.Forms.Button gumb { get; set; }
    }
}
