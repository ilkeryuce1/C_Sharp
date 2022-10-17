using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //systems.Collections.Generic
            //T-> object türündedir. Nesne alabilir
            
            List<int> listSayi = new List<int>();

            listSayi.Add(23);
            listSayi.Add(10);
            listSayi.Add(20);
            listSayi.Add(30);
            listSayi.Add(34);
            listSayi.Add(92);


            List<string> renkList = new List<string>();

            renkList.Add("Kırmızı");
            renkList.Add("Mavi");
            renkList.Add("Turuncu");
            renkList.Add("Sarı");
            renkList.Add("Yeşil");

            //Listelre içinde kaç eleman var yani COUNT alma
            Console.WriteLine(renkList.Count);
            Console.WriteLine(listSayi.Count);

            //Elemanları ekrana yazdırmak için de 

            foreach (var sayi in listSayi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine();
            foreach (var renk in renkList)
            {
                Console.WriteLine(renk);
            }


            // Listeden eleman çıkarmak içinde
            //******Umutulmamalıdır ki çıkardıktan sonra österecek kod olmazsa sadece çıakrır
            listSayi.Remove(23);
            renkList.Remove("Yeşil");

            //İndex kullaarak listeden eleman çıkarmak içindde

            listSayi.RemoveAt(4);
            renkList.RemoveAt(1);


            //********Önemli En çok kullanılan Kullanım böyledir foreach kullanımı 
            listSayi.ForEach(sayi=>Console.WriteLine(sayi));
            renkList.ForEach(renk=>Console.WriteLine(renk));


            //LİSTE İÇİNDE ARAMA 
            if (listSayi.Contains(10))
            {
                Console.WriteLine("Listede 10 sayısı var ");
            }


            //ELEMAN İLE İNDEXE ERİŞME 
            Console.WriteLine(renkList.BinarySearch("Kırmızı"));


            //DİZİYİ LİSTEYE ÇEVİRME
            String[] hayvanlar = { "at", "Eşek", "Kedi", "Köpek" };
            List<string> hayvanlistesi = new List<string>(hayvanlar);


            //Diziyi Liste İle nasıl temızlerım 
            hayvanlistesi.Clear();//liste temizlendi

            //LİSTE İÇİNDE NESNE TUTMAK İSTENİRSE 

            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.ad=





            Console.ReadLine();

        }
    }

    public class Kullanıcılar
    {
       string ad;
        private string soyad;
        int yaş;

        
    }
}
