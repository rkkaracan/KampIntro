using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //yorumlar böyle
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            bool sistemeGirişYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }



            if (sistemeGirişYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            } 
                
               
                
       Console.WriteLine(kategoriEtiketi);


        }
    }
}
