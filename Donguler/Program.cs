using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1="Yazılım Geliştirici Yetiştirme Kampı";

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı","Programlamaya başlangıç için kurs", "Java" };



            for (int i = 0; i <kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");

            foreach (string  kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu footer");

        }
    }
}
