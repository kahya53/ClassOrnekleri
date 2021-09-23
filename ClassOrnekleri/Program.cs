using System;

namespace ClassOrnekleri
{
    class Program
    {
        static void Main(string[] args)
        {

            #region UrunOzellik


            Urunler urun1 = new Urunler();
            urun1.urunAdi = "Radeon X5001";
            urun1.urunAdet = 110;
            urun1.urunFiyati = 100;
            urun1.urunOzellikleri = "Ürün Özellik 2";

            Urunler urun2 = new Urunler();
            urun2.urunAdi = "Radeon X3500";
            urun2.urunAdet = 210;
            urun2.urunFiyati = 100;
            urun2.urunOzellikleri = "Ürün Özellik 3";

            Urunler urun3 = new Urunler();
            urun3.urunAdi = "Radeon X5500";
            urun3.urunAdet = 510;
            urun3.urunFiyati = 100;
            urun3.urunOzellikleri = "Ürün Özellik 4";

            Urunler urun4 = new Urunler();
            urun4.urunAdi = "Radeon X6500";
            urun4.urunAdet = 104;
            urun4.urunFiyati = 100;
            urun4.urunOzellikleri = "Ürün Özellik 5";

            //Urunler[] prduct = new Urunler[] { urun1, urun2, urun3, urun4 };

            //foreach (var item in prduct)
            //{
            //    Console.WriteLine(item.urunAdet);
            //    Console.WriteLine("********");
            //}

            //for (int i = 0; i < prduct.Length; i++)
            //{
            //    Console.WriteLine(prduct[i].urunAdi);
            //    Console.WriteLine("****xxx****");
            //}

            //int ii = 0;
            //while (ii == prduct.Length)
            //{
            //    ii = ii+ii;

            //    Console.WriteLine(prduct[ii].urunOzellikleri);
            //    Console.WriteLine("**yyyy**");
            //}

            #endregion

            #region Sepete Ekel

            SepetManager Sepetim = new SepetManager();
            Sepetim.Ekle(urun1);
            Sepetim.Ekle(urun2);
            Sepetim.Ekle(urun3);
            Sepetim.Ekle(urun4);

            #endregion

            Console.ReadLine();
        }

    }
}
