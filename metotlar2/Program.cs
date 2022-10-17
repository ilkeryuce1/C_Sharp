using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace metotlar


{
    internal class Program
    {

       
        static void Main(string[] args)
        {
            // erişim_belirteci geri_donus_tipi metot_adı(parametrelistesi/arguman)
            //{
            //    komutlar
            //} public metot her yerden erişilir.
            int a = 3;
            int b = 5;

            Console.WriteLine(a + b);
            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

           
            int sonuc2 = ornek.ArttırVeTopla(ref a,ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a + b));


            Console.Read();
        }
        // metot olarak ise
        static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2); 
            // parametrenın değerlerini a ve b nın değerlerini gidip topla fonksıyonuna verdık 
            // parametreye sadece bu fonksıyonda erişilir tekrar erişilemez
        }

        class Metotlar

        {
           public  void EkranaYazdir(string veri)
            {
                Console.WriteLine(veri);
            }

            public int ArttırVeTopla(ref int sayı1, ref int sayı2)
                // ref bellekteki karşılıklarıdır orjınal adrestekı yerlerı uzerınde değısıklık yapmaktadır.
            {
                sayı1 += 1;
                sayı2 += 1;
                return sayı1 + sayı2;
            }


        }

    }
   
}
