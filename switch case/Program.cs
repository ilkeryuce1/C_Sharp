using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace konsol
{
    internal class Program
    {
        static void Main(string[] args)
        {
     // sıralama hıç onemlı değil syntax bu şekilde 

            int AyHesap = DateTime.Now.Month;
            switch (AyHesap)
            {
                case 1:
                    Console.WriteLine("Ocak Ayındasınız"); break;
                case 2: Console.WriteLine("Şubat ayındasınız "); break;
                case 8: Console.WriteLine("Ağustos ayındasınız"); break;


                default:
                    Console.WriteLine("yanlış veri girildi");
                    break;
            }

            switch (AyHesap)
            {
                case 12:
                    case 1 :
                        case 2 :
                    Console.WriteLine("kış ayındasınız.");
                    break;

                case 3:
                    case 4 :
                        case 5 :
                    Console.WriteLine("İlkbahar ayındasınız");
                    break ;
                    case 6:
                            case 7 :
                                case 8 :
                    Console.WriteLine("Yaz ayındsınız");
                    break;

                case 9:
                    case 10 :
                        case 11 :
                            Console.WriteLine("Sonbahar Ayındasınız");
                    break;
                default:
                    break;
            }
            Console.Read();
        }
    }
}
