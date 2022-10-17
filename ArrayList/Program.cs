using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace arraylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.Collectıon namespace de bbulunur 

            ArrayList list = new ArrayList();
            //list.Add("Ali");
            //list.Add(2);
            //list.Add('a');
            //list.Add(true);

            ////içindeki verilere erişme 
            //Console.WriteLine(list[1]);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}


            //AddRange   birden fazla elemanı ekleme yontemı 
            Console.WriteLine("-----AddRane-----");
            //string[] renkler = { "kırmızı", "sarı", "pembe", "mor" };
            List<int> sayılar = new List<int>() {1,8,3,7,93,5 };
           //list.AddRange(renkler);
            list.AddRange(sayılar);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // SORT
            Console.WriteLine("*******SORT******");
            list.Sort(); // sayı dışında karakter varsa patlar.
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // BİNARY 
            Console.WriteLine("*******Binary******");
            Console.WriteLine(list.BinarySearch(5));

            //REVERSE
            Console.WriteLine("*****REverse******");
            //ilk değer sona son değer ılk basa alınır 

            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*****Clear******");
            //listeyı temızledı 
            list.Clear();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            Console.Read();
        }
    }
}
