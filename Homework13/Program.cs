using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 10 tane değer alsın
            //Tek ve çift sayıların kaç adet olduğunu söylesin
            //Tek ve çift değerlerin toplamını söylesin
            //Tek değerlerin toplamı çift değerlerin toplamından büyükse tek değerlerin toplami büyüktür yazdırsın
            //Çift değerlerin toplamı tek değerlerin toplamından büyükse çift değerlerin toplami büyüktür yazdırsın

            
            
            int [] sayilar = new int[10];
            int tekAdetToplamı = 0;
            int ciftAdetToplamı = 0;
            int tekSayilarinToplamı = 0;  
            int ciftSayilarinToplamı = 0;
            int kullaniciDeger;

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("Lütfen dizinin " +   (i+0)  +  ".İndex değerini giriniz");
                kullaniciDeger = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = kullaniciDeger;
            }
            for (int j = 0; j < sayilar.Length; j++)
            {
                if (sayilar[j]%2==0)
                {
                    ciftAdetToplamı++;
                    ciftSayilarinToplamı += sayilar[j];
                }
                else
                {
                    tekAdetToplamı++;
                    tekSayilarinToplamı += sayilar[j];
                }

                
            }

            if (ciftSayilarinToplamı > tekSayilarinToplamı)
            {
                Console.WriteLine("çift sayıların toplamı tek sayıların toplamından büyüktür");
            }
            else
            {
                Console.WriteLine("tek sayıların toplamı çift sayıların toplamından büyüktür");
            }
            Console.WriteLine("çift sayıların toplamı= " + ciftSayilarinToplamı);
            Console.WriteLine("çift sayıların adedi= " + ciftAdetToplamı);

            Console.WriteLine("tek sayıların toplamı= " + tekSayilarinToplamı);
            Console.WriteLine("tek sayıların adedi= " + tekAdetToplamı);

            Console.ReadLine();
        }
    }
}
