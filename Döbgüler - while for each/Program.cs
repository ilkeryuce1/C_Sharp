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
            //While

            // 1 den başlayarak konsoldan gırılen sayı dahıl ortalama hesaplayıp konsola yazdıran proram.
            Console.Write("Sayı giriniz: ");
            int deger = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= deger) // ifade karşılandığı surece dönü çalışır
            {
                toplam += sayac;
                sayac ++;

            }
            Console.WriteLine(toplam/deger);

            // a dan z ye kadar olan tum harflerı konsola yazdıralım 
            char karakter = 'a';


            while (karakter < 'z')
            {
                Console.Write(karakter);
                karakter++;
            }
            Console.WriteLine("");

            // FOREACH
            string[] arabalar = { "audı", "toyota", "ford", };
            
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
            Console.Read();

        }
    }
}
