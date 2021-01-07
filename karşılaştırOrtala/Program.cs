using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karşılaştırOrtala
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 54, - 76, 10, 21, - 49, 34 };

            /*önce ortalama*/
            // bu program sayılarımın ilkinden başlasın, sırayla tek tek eklesin
            // sayılar bitince de bu toplamı sayı miktarına bölsün sonra, bana söylesin 
            // bize bi döngü lazım ilk parça için

            int sayilarinToplami = 0;
         
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilarinToplami += sayilar[i];
            }

            int sayilarOrtalama = sayilarinToplami / sayilar.Length;
            
            Console.WriteLine("Sayıların ortalaması " + sayilarOrtalama);


            /*Sonra en büyük & en küçük sayı*/
            // En büyük sayı ortalamadan büyüktür bununla karşılaştırabiliriz
            // mesela ortalamadan büyük ve küçük sayıları bi yere koyalım sonra onları karşılaştıralım

            List<int> ortalamadanBuyuk = new List<int>();
            List<int> ortalamadanKucuk = new List<int>();

            for (int i = 0; i < sayilar.Length; i++)
            {
                int karsilasmaBir = sayilar[i].CompareTo(sayilarOrtalama);

                switch (karsilasmaBir)
                {
                    case -1:
                        ortalamadanKucuk.Add(sayilar[i]);
                        break;
                    case 0:
                        break;
                    case 1:
                        ortalamadanBuyuk.Add(sayilar[i]);
                        break;
                    default:
                        break;
                }
            }

            int enBuyuk = ortalamadanBuyuk.Max();
            int enKucuk = ortalamadanKucuk.Min();

            Console.WriteLine($"Sayıların arasından en büyük olan {enBuyuk}, en küçük olan {enKucuk}tür.");
            Console.ReadLine();







        }
    }
}
