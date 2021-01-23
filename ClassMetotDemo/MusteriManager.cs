using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) //musteri parametreleri kullanılacak
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " eklenmiştir.");
        }

        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("\nTüm Liste:");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + ":" + musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " " + musteri.TelNo);
            }
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("\n" + musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " silinmiştir.");
        }
    }
}
