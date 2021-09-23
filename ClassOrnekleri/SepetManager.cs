using System;
using System.Collections.Generic;
using System.Text;

namespace ClassOrnekleri
{
    class SepetManager
    {
        public void Ekle(Urunler urun)
        {
            Console.WriteLine("spete eklendi : " + urun.urunAdi + "  Fitaı : " + urun.urunFiyati + " TL" );
        }

     
      
    }
}
