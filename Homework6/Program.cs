using System;

namespace Homework6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //***1-50 Arası Rastgele  Sayı Oluşturma***
            int adet = 10;
            int[] sayilar = new int[adet];
            Random random = new Random();
            for (int i = 0; i < sayilar.Length; i++)
            {
                var rndm = random.Next(1, 50);

                var kullanilmis = false;
                for (int j = 0; j < i; j++)
                {
                    if (sayilar[j] == rndm)
                    {
                        kullanilmis = true;
                        i = i - 1;
                        Console.WriteLine(rndm + " sayısı daha önce kullnılmış. Tekrar kullanılamaz");
                    }
                }

                if (!kullanilmis)
                {
                    sayilar[i] = rndm;
                    Console.WriteLine(sayilar[i]);
                }


            }


            Console.ReadLine();
        }
    }
}
