using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace StrHazırMetotlar

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz";
            string degisken2 = "Dersimiz CSharp";
            string degisken3 = "dersimiz cSharp, Hoşgeldiniz";

            //Length ile cümledeki harf sayısı öğrenilebilir
            Console.WriteLine(degisken.Length);


            // Toupper ve Tolower  upper hepsini büyütür lower hepsini büyütür
            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(degisken.ToUpper());


            //concat Birleştirir
            Console.WriteLine(string.Concat(degisken, " Merhaba"));

            //Compare to birinci değişken 2. değişkene eşitse 0 döner
            //1. değişken 2. değişkenden daha buyuk bır karakter sayısına sahıpse 1 döner
            //eğr daha kuçuk bır karakter sayısına sahıpse -1 döner
            //COMPARE
            // true denilirse buyuk kuçuk duyarsız hale gelir falsede duyarlıdır 
            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(string.Compare(degisken,degisken2,true));
            Console.WriteLine(string.Compare(degisken, degisken3, false));

            //CONTAİNS değişken 1 içinde değişken 2 var mı bulursa true döner 
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz")); //bitiyor mu

            // İNDEXOF
            // değikenın olduu yerde yazılan karakterı arar ve ilk indexi verir
            //bulamazsa -1 doner 
            Console.WriteLine(degisken.IndexOf("CS"));

            //insert başlangıç indeksi alır ve ne ekleneceği yazılır
            Console.WriteLine(degisken.Insert(0, "Merhaba'  "));

            //LAST indexof  son ındekstekı aranan harfın yerını  getırır
            Console.WriteLine(degisken.LastIndexOf("i"));


            //PadLeft ve PadRight

            Console.WriteLine(degisken + degisken2.PadLeft(30));
            //30 verildi çünkü değişken 2 nın soluna 30 a tamamlayacak kadar boşluk ekler 
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));

            Console.WriteLine(degisken.PadRight(50) + degisken2);         
            Console.WriteLine(degisken.PadRight(50,'-') + degisken2);


            //REMOVE
            //10. karakterden sonrakını sıler atar 
            Console.WriteLine(degisken.Remove(10));

            //5.karakterden bşlayarak 3 karakter sılcek
            Console.WriteLine(degisken.Remove(5,3)); 
            //enbaştakını sılme
            Console.WriteLine(degisken.Remove(0,1));   
            

            //REPLACE
            //Metinsel ifadeyı buradakı ıle değiştir
            Console.WriteLine(degisken.Replace("CSharp","C#"));
            //Boşlukları yıldıza çevir
            Console.WriteLine(degisken.Replace(" ", "*"));


            //SPLİT
            //deiskenı boşluklara göre parçala diziye ata ve bana 1. elemanı getir
            Console.WriteLine(degisken.Split(' ')[1]);

            //SUBSTRİNG
            //4. indexten başlayarak diziyi hep getir
            Console.WriteLine(degisken.Substring(4));

            //4.indexten başlayarak 6 karakter getir
            Console.WriteLine(degisken.Substring(4,6));


            Console.Read();
        }
    }
}
