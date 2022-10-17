using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace metotlar_overloadın


{
    internal class Program
    {

       
        static void Main(string[] args)
        {
            //Rekürsif - Öz yinelemeli
            //3^4=3*3*3*3
            int sonuc = 1;
            for (int i = 1; i < 5; i++)
                sonuc = sonuc * 3;
            Console.WriteLine(sonuc);
        
           
            //Extension Metotlar
            string ifade = "İlker Yüce";
            bool result = ifade.BoslukKontrol();
            Console.WriteLine(result);

            if (result)
                Console.WriteLine(ifade.BoslukDegistir());

            Console.WriteLine(ifade.BuyukHarf());
            Console.WriteLine(ifade.KucukHarf());

            int[] dizi = { 4, 5, 6, 7, 0, 3 };
            dizi.diziSirala();
            dizi.EkranaYazdir();

            int sayi = 5;
            Console.WriteLine(sayi.CiftSayi());
            Islemler instance = new Islemler();
            Console.WriteLine(instance.Expo(3, 4));
            Console.WriteLine(ifade.GetFirstChar());


            Console.ReadLine();
        }
    }
    public class Islemler
    {
        //Rekürsif - Öz yinelemeli
        public int Expo(int sayi, int üs)
        {
            if (üs < 2)
                return sayi;
            return Expo(sayi, üs - 1) * sayi;
            //Expo(3,4)
            //Expo(3,3)*3;
            //Expo(3,2)*3*3;
            //Expo(3,1)*3*3*3;
            //3*3*3*3=3^4;
        }



    }
    //Extension Metotlar
    public static class Extension
    {
        public static bool BoslukKontrol(this string param) //this ifadesi olursa fonksiyon değil extension olur
        {
            return param.Contains(" "); //param.contains : sayar
        }
        public static string BoslukDegistir(this string param)
        {
            string[] dizi = param.Split();//param.Split : birleştir 
            return string.Join("", dizi); //string.join : degistir
        }
        public static string BuyukHarf(this string param)
        {
            return param.ToUpper();//param.ToUpper büyük harfe dönüştürür
        }
        public static string KucukHarf(this string param)
        {
            return param.ToLower();//küçük harfe dönüştürür
        }
        public static int[] diziSirala(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdir(this int[] param)
        {
            foreach (int item in param)
            {
                Console.WriteLine(item);
            }
        }
        public static bool CiftSayi(this int param)
        {
            return param % 2 == 0;
        }

        public static string GetFirstChar(this string param)
        {
            return param.Substring(0, 1); //0.indexten 1sonraki karaktere kadar getir
        }
       
    }
}





////Extension ve Rekürsif Metotlar-----------
////Extension(Genişletilmiş) Metot ----
////Extension Metotların kelime anlamı genişletilebilir metotlardır. C# 3.0 ile hayatımıza giren, aynı kodu defalarca yazmak yerine, bir kere yazıp her yerden erişebileceğimiz kolay kullanımı olan metotlardır.

////Extension metot yazarken dikkat etmemiz gereken bir kaç kural vardır. Şu şekilde :

////Static bir class içerisinde static bir metot olarak yazılmalılar.
////Extension metod da tanımlı parametrelerden sadece 1 tanesi this ile tanımlanabilir.
////Küçük bir örnek ile kullanımını görelim.

////public static class MyExtensionClass
////{
////    public static bool IsEventNumber(this int value)
////    {
////        if (value % 2 == 0)
////            return true;
////        else
////            return false;
////    }
////}
////Yukarıdaki örnekte static class içerisinde IsEventNumber adında bir extension metot görüyoruz. Metodun kendisi de static keywordü ile tanımlandı. this keywordünün uygulandığı parametreye bakarsak, integer ver tipindeki değişkenlere uygulanabilir is extension metot olduğunu görüyoruz. Sayısının çift olup olmaması durumuna göre de geriye bool bir değer dönüyor.

////Extension metotların kullanımını oturtmanın en kolay yolu öncelikle işi yapacak olan metodu istenileni karşılayacak şekilde yazmaktır. Daha sonradan class ve metodu static yaparak ve genişletilecek veri tipine bağlı parametrenin başına this anahtar kelimesi ekleyerek kullanabilirsiniz.

////Yukarıdaki extension metodun örnek kullanımı ise şu şekildedir.

////int deger = 123; bool isEven = deger.IsEvenNumber();

////Rekürsif(Yinelemeli) Metot Kullanımı
////Rekürsif metotlar ilk öğrenildiğinde içselleştirilmesi ve kullanılması zor metotlardır. Ama yazılımın ilerleyen yıllarında kullanımı oturur ve bir çok soruna rekürsif metotları kullanarak çözüm getirebilirsiniz. O nedenle acele etmemek gerek :)

////Çok sık olmasa da bazen fonksiyonun kendi kendini çağırmasına ihtiyaç duyarız. For döngüsü karmaşık bir kod yazarak da bu ihtiyacı karşılamak mümkün. Rekürsif fonksiyonlar ise tam da bu ihtiyaç için ortaya koyulmuştur.

////Rekürsif fonksiyon kendi kendini çağırma yeteneğine sahip olduğu için kullanırken çok dikkatli olmak gerek. En büyük sorunlardan biri sonsuz döngüye neden olmalı. Bu da System.StackOverflowException olarak bilinen hataya neden olur. Yani belleğin stack bölgesinde bu fonksiyon çağrımı için ayrılan alan tükenmiştir. Yinelemeli olarak yaptığınız işe bağlı olarak risk de artar.

////Aşağıdaki örneği inceleyerek ve hatta kağıt üzerinde yazarak yinelemeli fonksiyonların kullanımını daha iyi oturtabilirsiniz.

////static int FibonacciSerisi(int sayi)
////{
////    if (sayi == 0)
////        return 0;
////    elseif(sayi == 1)
////        return 1;
////    else
////        return FibonacciSerisi(sayi - 1) + FibonacciSerisi(sayi - 2);
////}
