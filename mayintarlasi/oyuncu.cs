using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayintarlasi
{
    class oyuncu
    {
        public int bombaSayisi;
        public oyuncu() { }

        public void ekle(string deger) {
            if(deger=="bomba")
            this.bombaSayisi+=1;



        }
    }
}
