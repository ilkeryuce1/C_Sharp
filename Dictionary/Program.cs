using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace dictionary

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using System.Collections.Generic; altındadır 
            Dictionary<int,string> kullanıcılar = new Dictionary<int,string>();

            kullanıcılar.Add(10, "Ali Yüce");
            kullanıcılar.Add(12, "veli mm");
            kullanıcılar.Add(18, "can ozak");
            kullanıcılar.Add(20, "saffet adam");

            //Dizinin Elemanlarına erişim
            Console.WriteLine("******Elemanlara Erişim*****");
            Console.WriteLine(kullanıcılar[12]);
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }

            //Count alma konusu
            Console.WriteLine("******Count alma*****");
            Console.WriteLine(kullanıcılar.Count);

            //contaıns fonksıyonu
            Console.WriteLine("******Contains*****");
            Console.WriteLine(kullanıcılar.ContainsKey(12));//True
            Console.WriteLine(kullanıcılar.ContainsValue("can ozak"));//True

            //eleman çıkarma 
            Console.WriteLine("******Eleman çıkarma Remove*****");
            Console.WriteLine(kullanıcılar.Remove(12));
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }

            //KEYS 
            Console.WriteLine("******Keys******");
            foreach (var item in kullanıcılar.Keys)
            {
                Console.WriteLine(item);
            }


            //VAlues
            Console.WriteLine("******VALUES*****");
            foreach (var item in kullanıcılar.Values)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
