using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Humide
    {
        private Huile huile;
        private Lait lait;
        private Oeuf oeuf;
        private Vanille vanille;

        public Humide(Huile huile, Lait lait, Oeuf oeuf, Vanille vanille)
        {
            this.huile = huile;
            this.lait = lait;
            this.oeuf = oeuf;
            this.vanille = vanille;
        }
    }
}
