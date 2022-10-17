using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace arraylar

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sort
            int[] sayıDizisi = { 1, 21, 14, 55, 66 };

            Console.WriteLine("Sırasız Liste Dizisi");


            foreach (var sayı in sayıDizisi)          
                Console.WriteLine(sayı);

                Console.WriteLine("Sıralı Liste Dizisi");
                Array.Sort(sayıDizisi); //Direk bu diziyi sıralayacak 

                foreach (var sayı in sayıDizisi)
                {
                    Console.WriteLine(sayı);
                }


            //Clear verdiğimiz dizideki indexten başlayarak eleman sayısı kadar değeri sıfırlıyor
            Console.WriteLine("BU ARRAY CLEAR");

            Array.Clear(sayıDizisi, 2, 2);
            // say dızısını kullanarak 2. indexten sonraki 2 elemanı sıfırlar
            foreach (var sayı in sayıDizisi)
                Console.WriteLine(sayı);


            //Reserve
            Console.WriteLine("**** Array Reserve ****");
            Array.Reverse(sayıDizisi);

            foreach (var sayı in sayıDizisi)
                Console.WriteLine(sayı);


            //İndexoff
            Console.WriteLine("**** Array indexoff ****");
            Array.IndexOf(sayıDizisi, 66);


            Console.WriteLine(Array.IndexOf(sayıDizisi, 66));

            // Resize
            Console.WriteLine("****array resize***");
            Array.Resize<int>(ref sayıDizisi, 8);
            sayıDizisi[5] = 79;
            sayıDizisi[6] = 99;
            sayıDizisi[7] = 77;
           



            foreach (var sayı in sayıDizisi)
                Console.WriteLine(sayı);

            Console.Read();
        }
    }
}
