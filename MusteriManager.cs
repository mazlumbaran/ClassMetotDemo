using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " - " + "Müşteri Eklendi! ");        
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " - " + "Müşteri Silindi! ");
        }

        public void MusteriGuncelleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " - " + "Müşteri Bilgileri Güncellendi! ");
        }
        public void MusteriListeleme(Musteri[] musteri)
        {
            foreach (var item in musteri)
            {
                Console.WriteLine("Müşteri Numarası : " + item.Id);
                Console.WriteLine("Müşteri Adı : " + item.Adi);
                Console.WriteLine("Müşteri Soyadı : " + item.Soyadi);
                Console.WriteLine("Müşteri Telefonu : " + item.MobilNo);
                Console.WriteLine("Müşteri Risk Yüzdesi : " + "% " + item.RiskYuzdesi);
                Console.WriteLine("-------------");
            }
        }

    }
}
