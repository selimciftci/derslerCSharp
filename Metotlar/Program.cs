using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";
            
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Kayısı";
            urun2.Fiyati = 25;
            urun2.Aciklama = "Malatya Kayısısı";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            //type safe -- tip güvenliği class baş harfi büyük atanan değer küçük harfle yazılır

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("-------------Metotlar--------------");
            //instance - Classlar çağırılırken 
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //Ekle2 metotu
            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 9);
            sepetManager.Ekle2("Karpuz","Diyarbakır Karpuzu", 12,8);
        }
       
    }
    
}

// Dont Repeat Yourself ( Kendini Tekrar Etme ) - Clean Code - Best Practice 