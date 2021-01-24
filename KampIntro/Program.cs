using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Gürkan";
            int yasi = 20;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Gürkan Çalışır";
            kurs1.IzlenmeOranı = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursunEgitmeni = "Engin Demiroğ";
            kurs2.IzlenmeOranı = 78;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C++";
            kurs3.KursunEgitmeni = "Berkay";
            kurs3.IzlenmeOranı = 80;
            

            Kurs[] kurslar = new Kurs[] {
            kurs1,kurs2,kurs3
            };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":  "+kurs.KursunEgitmeni);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public String KursunEgitmeni { get; set; }
        public int IzlenmeOranı { get; set; }
        

    }
}
