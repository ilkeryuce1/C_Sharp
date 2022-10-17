using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    internal class Program
    {


        
 
    
 


        public static bool asalmi(int sayi)
        {
            bool durum = false;

            int kontrol = 0;

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0) 
                {
                    kontrol = 1;
                    break;
                }
            }
            if (kontrol == 1)
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            return durum;
        }



        static void Main(string[] args)
        {


            


            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();
            Console.WriteLine("Sizden hesaplama işlemi için 20 adet sayı gırmenız ıstenıyor");
            
            for (int i = 0; i < 20; i++)
            {
                Console.Write(" Lütfen {0}. sayıyı gırın  giriniz : ", i + 1);
               int s = int.Parse(Console.ReadLine());
               
                if (asalmi(s))
                {
                    asalSayilar.Add(s);
                  
                }
                else
                {
                    asalOlmayanSayilar.Add(s);
                }

            }

            
         
                    Console.WriteLine("===========================");
                    Console.WriteLine("ASAL SAYILAR");
                    foreach (int sayi in asalSayilar)
                    {
                        Console.WriteLine(sayi + "    ");
               
                    }
                    Console.WriteLine();
                    Console.WriteLine("ASAL OLMAYAN SAYILAR");
                    Console.WriteLine("===========================");
                    foreach (int sayi in asalOlmayanSayilar)
                    {
                        Console.WriteLine(sayi + "    ");
                   
            }
            Console.WriteLine("asal olan eleman sayıları: ");
            int elemanSayisi = asalSayilar.Count;
            Console.WriteLine(elemanSayisi);

            Console.WriteLine("asal olmayan eleman sayılar : ");
            int elemanSayisi1 = asalOlmayanSayilar.Count;
            Console.WriteLine(elemanSayisi1);



            Console.WriteLine("Asal olmayan SAyıları Büyükten küçüğe ısralamaa");

            //SAYILARI  BÜYÜkten KÜÇÜĞE SIRALAMA
            asalOlmayanSayilar.Sort(); //artan sırada sırala
            asalOlmayanSayilar.Reverse();//tersten sırala
            foreach (int deger in asalOlmayanSayilar)
            {
               
                Console.WriteLine(deger + " ");
            }

            Console.WriteLine("Asal olan SAyıları Büyükten küçüğe ısralamaa");

            //SAYILARI  BÜYÜkten KÜÇÜĞE SIRALAMA
            asalSayilar.Sort(); //artan sırada sırala
            asalSayilar.Reverse();//tersten sırala
            foreach (int deger in asalSayilar)
            {

                Console.WriteLine(deger + " ");
            }






            //



            float toplam = 0;
            foreach (int sayi in asalSayilar)
            {
                toplam += sayi;
            }
            Console.WriteLine("Asal ortalama :   " + toplam / elemanSayisi);

           float toplam1 = 0;
            foreach (int sayi in asalOlmayanSayilar)
            {
                toplam1 += sayi;
            }
            Console.WriteLine("Asal olmayan ortalama :   " + toplam1 / elemanSayisi1);

            Console.Read();
        }
    }
}
