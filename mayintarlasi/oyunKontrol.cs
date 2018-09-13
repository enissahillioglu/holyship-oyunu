using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayintarlasi
{
    class oyunKontrol
    {
        public oyunKontrol() { }

        Random r = new Random();
        public int rastgele;
        public Color rastgelerenk()
        {
            rastgele = r.Next(0,5);

            if (rastgele==0)
            {
                return Color.Blue;
            }
            if (rastgele == 1)
            {
                return Color.Gold;
            }
            if (rastgele == 2)
            {
                return Color.Yellow;
            }
            if (rastgele == 3)
            {
                return Color.Green;
            }
            if (rastgele == 4)
            {
                return Color.Pink;
            }
            if (rastgele == 5)
            {
                return Color.Violet;
            }

            return Color.Wheat;
        }

        public void oyunBitti() {


        }
    }
}
