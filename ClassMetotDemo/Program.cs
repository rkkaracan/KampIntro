using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1000;
            musteri1.Adi = "Ali";
            musteri1.Soyadi = "Yılmaz";
            musteri1.Tckn = 1234567;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1001;
            musteri2.Adi = "Ayşe";
            musteri2.Soyadi = "Büyükkaya";
            musteri2.Tckn = 7654321;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 1002;
            musteri3.Adi = "Berrak";
            musteri3.Soyadi = "Turan";
            musteri3.Tckn = 3215476;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 1003;
            musteri4.Adi = "Dilek";
            musteri4.Soyadi = "Duman";
            musteri4.Tckn = 6745123;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            MusteriManager musteriManager = new MusteriManager();



            Console.WriteLine("ANA MENÜ");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1) Müşterileri Listele");
            Console.WriteLine("2) Yeni Müşteri Ekle");
            Console.WriteLine("3) Müşteri Sil");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Lütfen yapmak istediğiniz işlemin kodunu giriniz:");

            string islem=Console.ReadLine();

            if (islem == "1")
            {
                foreach (var musteri in musteriler)
                {
                    musteriManager.MusterileriListeleme(musteri);
                }
            }
            else if (islem == "2")
            {
                musteriManager.MusteriEkle();
            }
            else if (islem == "3")
            {
                musteriManager.MusteriSilme();
            }
            else if (1==1)
            {
                Console.WriteLine("Hatalı bir değer girdiniz. Lütfen menüdeki değerlerden birini girin");
            }
        }
    }
}
