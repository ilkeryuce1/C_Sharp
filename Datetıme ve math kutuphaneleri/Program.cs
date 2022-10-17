using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MathHazırMetotlar

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            //Örnek syn kullaımı bu şekilde 
            Console.WriteLine(DateTime.Now.Date);
            //...


            //Format
            //day -1-2-3 d m y ile kulllanılabuılır
            Console.WriteLine(DateTime.Now.ToString("dddd"));
            Console.WriteLine();


            Console.WriteLine("MATH KÜYÜPHANESİ");
            Console.WriteLine();
            //MATH KÜTÜPHANESİ
            //abs mutlak değer 
            Console.WriteLine(Math.Abs(-25));//25
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));


            //Double değişkenlerde çalışan ceiling x den buyuk en kuçuk sayı
            Console.WriteLine(Math.Ceiling(22.3));//23

            //EN yakın sayıya yuvarlar 
            Console.WriteLine(Math.Round(22.7));//23

            //floor alta yuvarlar
            Console.WriteLine(Math.Floor(22.7));//22


            Console.WriteLine(Math.Max(2,6));// max = 6
            Console.WriteLine(Math.Min(2, 6));// min =2

            Console.WriteLine(Math.Pow(3, 4));// 3^4 == 81 Üs alma
            Console.WriteLine(Math.Sqrt(9));// karekök alır == 3

            Console.WriteLine(Math.Log(9));// log alma 

            Console.WriteLine(Math.Exp(3)); // e üzeri 3 ü verir

            Console.WriteLine(Math.Log10(10));// Log 10 tabanındakı karşılığı







            Console.Read();
        }
    }
}
 