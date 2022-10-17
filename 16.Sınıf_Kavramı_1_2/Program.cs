using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıf_Kavramı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //erişim belirleyiciler
            //public == her yerden erişilebilir
            // private == Sadece tanımlandığı sınıfta erişilebilen proplar
            //internal == sadece o proje ıcıne erısılebılen 
            //protect == sadece tanımlandığı sınıf ve o sınıftan miras alan yerlerde


            //Calisan calisan1 = new Calisan();
            // calisan1.Ad = "Ali";
            // calisan1.Soyad = "Yüce";
            // calisan1.No = 1453;
            // calisan1.Departman = "Mekanik";
            // calisan1.CalisanBilgileri();

            // Calisan calisan2 = new Calisan();
            // calisan2.Ad = "İlker";
            // calisan2.Soyad = "Yüce";
            // calisan2.No = 1294;
            // calisan2.Departman = "sft";
            // calisan2.CalisanBilgileri();
            // Console.ReadLine();


            //Diğer kullanım
            Console.WriteLine("Çalısan1");
            Calisan calisan1 = new Calisan("Ali","Yüce",1453,"Mekanik");
     
            calisan1.CalisanBilgileri();

            Console.WriteLine("Calısan2");
            Calisan calisan2 = new Calisan("İlker","Yüce",1294,"Sft");
          
            calisan2.CalisanBilgileri();

            Console.WriteLine("Calısan3");
            Calisan calisan3 = new Calisan("Mehmet", "Erdal",1453,"lşllşş");
            calisan3.CalisanBilgileri();

            Console.ReadLine();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        //kurucu fonksiyonlar
        //kurucu metotlar bır sınıfın nesnesı olusunca arka planda otomatık olusan metotlardır 
        //kurucun metotları public olmak zorunda ve gerı donus tipleri yoktur
        //str null
        //int 0 olarak boş ataanır
        public Calisan (string ad,string soyad,int no, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            No = no;
            Departman= departman;

        }
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı : {0}", Ad) ;
            Console.WriteLine("çalışan Soyad : {0}", Soyad);
            Console.WriteLine("çalışan no : {0}", No);
            Console.WriteLine("çalışan departman : {0}", Departman);
            Console.WriteLine();
        }
        
    }
   

    
}
