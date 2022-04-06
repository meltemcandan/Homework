using System;

namespace Homework26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Maaşı ve zam oranı girilen işçinin zamlı maaşını hesaplayarak ekranda gösteren program

            double maas, zamOranı, guncelMaas;
            Console.Write("Lütfen maaşınızı giriniz: ");
            maas= Convert.ToDouble(Console.ReadLine());
            Console.Write("Lütfen yüzde cinsinden zam oranınızı giriniz: ");
            zamOranı= Convert.ToDouble(Console.ReadLine());
            guncelMaas = maas + (maas * (zamOranı/100));
            Console.WriteLine("Güncel maaşınız: " + guncelMaas);
            Console.ReadLine();
        }
    }
}
