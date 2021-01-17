using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Siralama(Musteri[] musteri)
        {
            foreach (Musteri musteriler in musteri)
            {
                Console.WriteLine(musteriler.Ad+"\n"+musteriler.Soyad+"\n"+musteriler.Id);
            }
        }
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine($"{musteri.Ad} {musteri.Soyad} {musteri.Id}Eklendi");
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine($"{musteri.Ad} {musteri.Soyad} {musteri.Id}silindi");
        }
    }
}
