using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();
            Musteri musteri3 = new Musteri();
            musteri1.Ad = "ismail";
            musteri1.Soyad = "Eroglu";
            musteri1.Id = 561834556;

            musteri2.Ad = "Enes";
            musteri2.Soyad = "Seroglu";
            musteri2.Id = 564524556;

            musteri3.Ad = "Sencer";
            musteri3.Soyad = "Güroglu";
            musteri3.Id = 5234856;

            MusteriManager Yonetim = new MusteriManager();
            Musteri[] musteriler = new Musteri[]{musteri1,musteri2,musteri3};
            Yonetim.Siralama(musteriler);
            Yonetim.Ekle(musteri1);
            Yonetim.Silme(musteri3);



        }
    }
}
