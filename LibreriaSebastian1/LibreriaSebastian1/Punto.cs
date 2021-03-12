using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSebastian1
{
    public class Punto
    {
        private int x;
        private int y;

        public Punto()
        {
            this.x = 0;
            this.y = 0;
        }

        public Punto(int xx, int yy)
        {
            this.x = xx;
            this.y = yy;
        }

        public int X   // property
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }

        }

        public bool AbscisaIgualOrdenada()
        {
            return this.x == this.y;
        }
        public bool SobreEje()
        {
            return this.x == 0 || this.y == 0;
        }
        public int Cuadrante()
        {
            if ((x > 0) && (y > 0))
                return 1;

            if ((x > 0) && (y < 0))
                return 2;

            if ((x < 0) && (y < 0))
                return 3;

            if ((x < 0) && (y > 0))
                return 4;
            else

                return 0;

        }
        public bool PuntosIguales(Punto elemento)
        {
            return ((this.x == elemento.x) && (this.y == elemento.y));
        }

    }


}