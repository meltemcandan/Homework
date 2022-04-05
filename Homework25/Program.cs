using System;

namespace Homework25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcı tarafından girilen üç sayıdan en büyük ile en küçük sayıyı toplayıp toplam sonucu ekrana yazdıran programı yazınız.

            int sayi1, sayi2, sayi3, buyukSayi, kucukSayi;
            Console.WriteLine("1. sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. sayıyı giriniz: ");
            sayi3 = Convert.ToInt32(Console.ReadLine());

            if (sayi1>sayi2 && sayi1>sayi3)
            {
                 buyukSayi = sayi1;

            }
            else if (sayi2>sayi3)
            {
                 buyukSayi = sayi2;
            }
            else
            {
                 buyukSayi = sayi3;
            }

            if (sayi2> sayi1 && sayi3> sayi1)
            {
                 kucukSayi = sayi1;  
            }
            else if (sayi2<sayi3)
            {
                 kucukSayi = sayi2;
            }
            else
            {
                 kucukSayi = sayi3;
            }
            Console.WriteLine("En küçük ve en büyük sayının toplamı: " + (buyukSayi + kucukSayi));
            Console.ReadLine();
        }
    }
}
