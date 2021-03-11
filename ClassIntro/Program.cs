using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {


            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Metin Ayhan";
            kurs1.Egitmenyasi = 36;
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C++";
            kurs2.Egitmen = "Ayşe Akyüz";
            kurs2.Egitmenyasi = 28;
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Erhan Tunç";
            kurs3.Egitmenyasi = 32;
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "Python";
            kurs4.Egitmen = "Elif Aydemir";
            kurs4.Egitmenyasi = 26;
            kurs4.IzlenmeOrani = 60;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.Egitmenyasi + " : " + kurs.Egitmen + " : " + kurs.IzlenmeOrani + " : " + kurs.KursAdi);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
        public int Egitmenyasi { get; set; }
    }
}
