using System;

namespace Homework32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verilen bir karakter dizininin substring() metodunu kullanarak string içerisinde arama yapan ve kaç defa geçtiğini bulan program
            int sayac = 0;
            string metin = "mevsimler: Kış, İlkbahar, Yaz, Sonbahar";
            string aranan = "Yaz";
            int metinuzunluk = metin.Length;
            int arananuzunluk = aranan.Length;

            for (int i = 0; i <= (metinuzunluk - arananuzunluk); i++)
            {
                if (metin.Substring(i, arananuzunluk) == aranan)
                {
                    sayac++;
                }
            }
            Console.WriteLine(sayac);
            Console.ReadKey();
        }
    }
}
