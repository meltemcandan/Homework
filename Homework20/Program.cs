using System;

namespace Homework20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Girilen 3 basamaklı sayıyı basamaklarına ayıran örnek 

            Console.WriteLine("Lütfen 3 basamaklı bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int yuzler = sayi / 100;
            sayi = sayi - (yuzler * 100);
            int onlar = sayi / 10;
            sayi = sayi - (onlar * 10);
            int birler = sayi;

            Console.WriteLine("Yüzler basamağı: " + yuzler);
            Console.WriteLine("Onlar basamağı: " + onlar);
            Console.WriteLine("Birler basamağı: " + birler);
            Console.ReadLine();
        }
    }
}
