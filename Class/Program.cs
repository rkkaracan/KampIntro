using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Engin Demirog";
            kurs1.IzlenmeOrani = 68;



            Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string  KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }

}
