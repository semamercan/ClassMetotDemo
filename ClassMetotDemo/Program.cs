using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri(); //instance
            musteri1.Id = 1;
            musteri1.MusteriAdi = "Sema";
            musteri1.MusteriSoyadi = "Mercan";
            musteri1.TelNo = "05555555555";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAdi = "Beyza";
            musteri2.MusteriSoyadi = "Mercan";
            musteri2.TelNo = "05553333333";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler) //musteriler arrayında döner. musteri her müşterinin takma ismidir.
            {
                Console.WriteLine(musteri.MusteriAdi);
                Console.WriteLine(musteri.MusteriSoyadi);
                Console.WriteLine(musteri.TelNo);
                Console.WriteLine("----------------------");
            }

            MusteriManager musteriManager = new MusteriManager(); //instance
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Listele(musteriler);
            musteriManager.Sil(musteri1);
           


        }
    }
}
