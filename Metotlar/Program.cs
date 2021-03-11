using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] meyveler = new string[] { "Elma", "Karpuz" };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun urun3 = new Urun();
            urun3.Adi = "Armut";
            urun3.Fiyati = 17;
            urun3.Aciklama = "Batman Armutu";

            Urun urun4 = new Urun();
            urun4.Adi = "Kavun";
            urun4.Fiyati = 29;
            urun4.Aciklama = "Kastamonu'nun Lezzeti";

            Urun urun5 = new Urun();
            urun5.Adi = "Erik";
            urun5.Fiyati = 51;
            urun5.Aciklama = "Kütür Kütür Ekşi Erik";

            Urun urun6 = new Urun();
            urun6.Adi = "Kayısı";
            urun6.Fiyati = 33;
            urun6.Aciklama = "Malatya'nın Kaysısı";



            Urun[] urunler = new Urun[] { urun1, urun2, urun3, urun4, urun5, urun6 };


            //type-safe -- tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------------");
            }

            Console.WriteLine("--------------Metotlar---------------");

            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);
            sepetManager.Ekle(urun4);
            sepetManager.Ekle(urun5);
            sepetManager.Ekle(urun6);

            sepetManager.Ekle2("Armut", "Yeşil", 12, 12);
            sepetManager.Ekle2("Karpuz", "Kan Kırmızı", 12, 5);
            sepetManager.Ekle2("Elma", "Kırmızı", 12, 3);

        }
    }
}



//Do not repeat yourself - DRY - Clean Code - Best Practice