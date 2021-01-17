using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "Kılıç";
            musteri1.Id = 00001;
            musteri1.MusteriNo = 0123456789;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Mehmet";
            musteri2.Soyadi = "Yıldız";
            musteri2.Id = 00002;
            musteri2.MusteriNo = 0123486789;


            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Ayşe";
            musteri3.Soyadi = "Toprak";
            musteri3.Id = 00003;
            musteri3.MusteriNo = 0123986789;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);



        }
    }
}
