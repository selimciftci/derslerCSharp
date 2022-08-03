using System;


namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region dongu
            string[] kurslar = new string[] { "Yazılım Geliştirici yetiştirme kursu",
                    "Programlamaya Başlangiç İçin Temel Kurs",
                    "Java","Python"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("footer - sayfa sonu ");

            // foreach sadece diziler için kullanılan döngü çeşitidir.
            // python for dögüsü ile aynı çalışır.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            //************************************************
            Console.WriteLine("for bitti");

            #endregion


            // ternary operatör ( tek satırda şart bloğu yazımı)
            // kontrol edilecek işlem? birinci sonuç(if) : ikinci sonuç
            //if else yapısı  
            string kullaniciAdi = "", sifre = "";
            Console.WriteLine("Kullanici Adini Girin: ");
            kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Sifreyi Girin");
            sifre = Console.ReadLine();
            if (kullaniciAdi == "admin" && sifre == "12345")
            {
                Console.WriteLine("Giris Basarili");
            }
            else
            {
                Console.WriteLine("Kullanici adi ve ya sifre hatali");
            }
            // ternary operatör yapısı
            string kullaniciAdi1 = "", sifre1 = "";
            Console.WriteLine("Kullanici Adini Girin: ");
            kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Sifreyi Girin");
            sifre = Console.ReadLine();
            string durum = (kullaniciAdi1 == "admin" && sifre1 == "12345") ? "Giris Basarili" : "Kullanici adi ve ya sifre hatali";
            Console.WriteLine(durum);

        }
    }
}
