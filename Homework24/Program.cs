using System;

namespace Homework24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir komisyoncu sattığı mallardan fiyatı 50 TL kadar olanlardan % 3, daha fazla olanlardan ise % 2 komisyon almaktadır. Klavyeden girilen teker teker girilen 5 malın komisyonlarını bulup ekrana yazdıran ve en sonunda da toplam komisyonu ekrana yazdıran programın kodlarını yazınız.

            double malFiyati = 0, komisyonMiktari = 0, toplamKomisyon = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0}. Malın Fiyatını Giriniz : ", i + 1);
                malFiyati = Convert.ToDouble(Console.ReadLine());
                if (malFiyati > 50)
                { komisyonMiktari = malFiyati * 0.02; }
                else
                { komisyonMiktari = malFiyati * 0.03; }
                Console.WriteLine("{0}. Mal İçin Komisyon Miktarı : {1}", i + 1, komisyonMiktari);
                toplamKomisyon += komisyonMiktari;
            }
            Console.WriteLine("Toplam Komisyon Miktarı : {0}", toplamKomisyon);

            Console.ReadLine();

        }
    }
}
