using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dizler 0 dan başlar
            string[] renk = new string[5];

            string[] hayvanlar = { "kedi", "köpek", "At", "eşek", "dana" };

            int[] dizi;
            dizi = new int[5];

            //dizilerde değer atama ve erişim
            renk[0] = "mavi";
             dizi[3] = 10;

            Console.WriteLine(hayvanlar[2]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renk[0]);


            // Döngülerle Kullanımları
            //klavyeden girilen n tane sayının ortalamasını alan program

            Console.Write("Dizi Eleman sayısı:   ");
            int diziuzunluu = int.Parse(Console.ReadLine());
            int[] sayidizisi = new int[diziuzunluu];


            for (int i = 0; i < diziuzunluu; i++)
            {
                Console.Write("Lütfen {0}. elemamı giriniz :  ", i + 1);
                sayidizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayidizisi)
            {
                toplam += sayi;
            }
            Console.WriteLine("ortalama :   " + toplam / diziuzunluu);
            Console.Read();
        }
    }
}
