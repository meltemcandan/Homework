using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Her katında 2 odası bulunan otelin tek haneli odalarının günlük kirası 150 TL den, çift haneli odalarının günlük kirası 200 TL den başlayacak ve bu kiralar katlara oranla artacak kullanıcı katı, odayı ve kalmak istediği gün sayısını kendisi girecek  toplam ödemesi gereken kirayı ekrana yazan program
            int tek = 150, cift = 200, oda_no, kat_no, gün;
            Console.WriteLine("Otelimize Hoşgeldiniz");
            Console.WriteLine("Lütfen kalmak istediğiniz katın numarasını giriniz.");
            kat_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen kalmak istediğiniz gün sayısını giriniz.");
            gün = Convert.ToInt32(Console.ReadLine());


            switch (kat_no)
            {
                case 1:
                    Console.WriteLine("Bu kattaki odalar 1 ve 2 birini seçiniz");
                    oda_no = Convert.ToInt32(Console.ReadLine());
                    switch (oda_no)
                    {
                        case 1:
                            Console.Write("Toplam ödemeniz gereken kira:   {0} TL", (tek * kat_no) * gün);
                            break;
                        case 2:
                            Console.Write("Toplam ödemeniz gereken kira:   {0} TL", (cift * kat_no) * gün);
                            break;
                        default:
                            Console.Write("Yanlış oda numarası girdiniz!");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Bu kattaki odalar 3 ve 4 birini seçiniz");
                    oda_no = Convert.ToInt32(Console.ReadLine());
                    switch (oda_no)
                    {
                        case 3:
                            Console.Write("Toplam ödemeniz gereken kira:   {0} TL", (tek * kat_no) * gün);
                            break;
                        case 4:
                            Console.Write("Toplam ödemeniz gereken kira:   {0} TL", (cift * kat_no) * gün);
                            break;
                        default:
                            Console.Write("Yanlış oda numarası girdiniz!");
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Bu kattaki odalar 5 ve 6 birini seçiniz");
                    oda_no = Convert.ToInt32(Console.ReadLine());
                    switch (oda_no)
                    {
                        case 5: Console.Write("Toplam ödemeniz gereken kira:   {0} TL", (tek * kat_no) * gün); break;
                        case 6: Console.Write("Toplam ödemeniz gereken kira:   {0} TL", (cift * kat_no) * gün); break;
                        default: Console.Write("Yanlış oda numarası girdiniz!"); break;
                    }
                    break;
                case 4:
                    Console.WriteLine("Bu kattaki odalar 7 ve 8 birini seçiniz");
                    oda_no = Convert.ToInt32(Console.ReadLine());
                    switch (oda_no)
                    {
                        case 7: Console.Write("Toplam ödemeniz gereken kira:   {0} TL", (tek * kat_no) * gün); break;
                        case 8: Console.Write("Toplam ödemeniz gereken kira:   {0} TL", (cift * kat_no) * gün); break;
                        default: Console.Write("Yanlış oda numarası girdiniz!"); break;
                    }
                    break;
                case 5:
                    Console.WriteLine("Bu kattaki odalar 9 ve 10 birini seçiniz");
                    oda_no = Convert.ToInt32(Console.ReadLine());
                    switch (oda_no)
                    {
                        case 9: Console.Write("Toplam ödemeniz gereken kira:   {0} TL", (tek * kat_no) * gün); break;
                        case 10: Console.Write("Toplam ödemeniz gereken kira:   {0} TL", (cift * kat_no) * gün); break;
                        default: Console.Write("Yanlış oda numarası girdiniz!"); break;
                    }
                    break;
                default:
                    Console.WriteLine("Yanlış oda numarası girdiniz!"); break;

            }
            Console.ReadLine();
        }
    }
}
