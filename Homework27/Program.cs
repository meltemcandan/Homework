using System;

namespace Homework27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Elemanları tam sayı olan bir A dizisinin(20 elemanlı) rastgele sayılar atayan, sonra dizi elemanlarının aritmetik ortalamasını hesaplayan ve elemanlardan kaç tanesinin bu ortalamadan büyük ve küçük olduğunu sayan programın  kodlarını yazınız.
            int[] dizi= new int [20];
            Random rand = new Random();
            
            int diziToplamı = 0;
            int buyuk = 0;
            int kucuk = 0;
            double diziOrtalama= 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rand.Next(1,100);
                diziToplamı+=dizi[i];
                Console.WriteLine(dizi[i]);
            }
            diziOrtalama = diziToplamı / 20;
            foreach (int dizim in dizi)
            {
                if (dizim > diziOrtalama)
                {
                    buyuk += 1;
                }
                else
                { 
                    kucuk += 1; 
                }

            }
            Console.WriteLine("Dizi ortalaması = " + diziOrtalama);
            Console.WriteLine("Dizide ortalamadan büyük eleman sayısı= " + buyuk);
            Console.WriteLine("Dizide ortalamadan küçük eleman sayısı= " + kucuk);
            Console.ReadKey();

        }
    }
}
