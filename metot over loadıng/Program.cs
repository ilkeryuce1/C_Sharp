using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace metotlar_overloadın


{
    internal class Program
    {

       
        static void Main(string[] args)
        {
            //alt parametreler
            string sayi = "999";
         bool sonuc =   int.TryParse(sayi, out int outsayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outsayi);

            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4, 5, out int ToplamSonuc);
            Console.WriteLine(ToplamSonuc);



            // Metot Overloading Aşırı yukleme 

            int sayı = 999;
            instance.EkranaYazdir(Convert.ToString(sayı));
            instance.EkranaYazdir(sayı);
            instance.EkranaYazdir("İlker", "Yüce");

            // Metot ımzası 
            // metot adı + parametre sayısı + parametre





            Console.Read();
        }
       
    }
   

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;

        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}
