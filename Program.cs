using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 0001;
            musteri1.Adi = "Hasan";
            musteri1.Soyadi = "Gürbüz";
            musteri1.MobilNo = 01234567890;
            musteri1.RiskYuzdesi = 5;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 0002;
            musteri2.Adi = "Engin";
            musteri2.Soyadi = "Demiroğ";
            musteri2.MobilNo = 01547567890;
            musteri2.RiskYuzdesi = 51;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 0003;
            musteri3.Adi = "Mazlum";
            musteri3.Soyadi = "Baran";
            musteri3.MobilNo = 01265417890;
            musteri3.RiskYuzdesi = 14;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);

            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
            
            musteriManager.MusteriGuncelleme(musteri3);

            Console.WriteLine("----------MÜŞTERİ LİSTESİ------------");
            musteriManager.MusteriListeleme(musteriler);
        }
    }
}
