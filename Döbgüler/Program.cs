using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsol
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            // kodun bırden fazla defa çalışmasını ıstıyorsak FOR kullanılır.



            //Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdı.
            Console.Write("Sayı Giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 0; i <= sayac; i++)
            // i 0 dan başlayıp  her döngüde 1 artırılarak foru dön her seferınde komutlaru-ı çalıştır
            {

                // Eğer İ sayısının 2 ye bölümünden 1 kalırsa kalanları ekrana yazdır .
                if (i %2 == 1)
                {
                    Console.WriteLine(i);
                }


            }

            // 1 ile 1000 arasındaki tek ve çift sayıların kendı içlerindeki toplamlarını ekran yazdır.
            int tektoplam = 0;
            int cıftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {

                if (i % 2 == 1) // i sadece burada for ıcınde kullanıldı
                {
                    tektoplam += i; //Tek toplam = Tek toplam + i,,;
                   
                }
                else
                {
                    cıftToplam += i;
                }
                Console.WriteLine("Tek toplam : " + tektoplam);
                Console.WriteLine("Çift toplam : " + cıftToplam);

                //mevcut dönünün o kod bloğunda çalışmasını ıstersen continue ile istenen değer atlanıp devam edılır
                // break; Döngüden çıkmak için kullanılır
            }



            Console.Read();

        }
    }
}
