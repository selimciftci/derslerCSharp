using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        // Naming Convention. isimlendirme kuralı baş harfi büyük yazılır
        // parametre değeri alır
        // Urun Tipi - urun ise aşağıda verilen takma isim
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi! : " + urun.Adi );
        }

        //bu gibi metot oluşturmalarda daha sonradan değiştirilen urun özellliği ayrı ayrı
        //değiştirilmesi gerektiğinden kullanışlı olmaz.
        public void Ekle2(string urunAdi, string Aciklama, double fiyat, int stokAdedi )
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urunAdi);
        }
    }
}
