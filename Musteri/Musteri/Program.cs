using System;

namespace Musteri
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "MELEK";
            musteri1.Soyad = "OLCAY";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "DİLEK";
            musteri2.Soyad = "DENİZ";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "EREN";
            musteri3.Soyad = "YILMAZ";

            Musteri[] musteriler = new Musteri[]{ musteri1, musteri2,musteri3};
           
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Id: " + musteri.Id);
                Console.WriteLine("Müşteri Adı: " + musteri.Adi);
                Console.WriteLine("Müşteri Soyadı: " + musteri.Soyad);
                Console.WriteLine("--------------------");

            }
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Listele(musteriler);
            musteriManager.Silme(musteri1);



            Console.ReadLine();

        }
    }
}
