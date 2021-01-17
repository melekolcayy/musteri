using System;
using System.Collections.Generic;
using System.Text;

namespace Musteri
{
    class MusteriManager
    {

        private Musteri musteri = new Musteri();
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("{0} {1} isimli müsteri eklendi.", musteri.Adi, musteri.Soyad);
        }
        public void Listele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("{0} {1}", musteri.Adi, musteri.Soyad);
            }
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine("{0} {1} isimli müsteri silindi.", musteri.Adi, musteri.Soyad);

        }
    }
}
