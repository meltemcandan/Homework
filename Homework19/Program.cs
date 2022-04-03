using System;

namespace Homework19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Hyundai", "Bayon", "Gri", 2021, 3);

            string CarData = car1.CarData();
            Console.WriteLine("Araba Bilgileri:\n\n" + CarData);
            Console.WriteLine();
            Console.WriteLine("Lütfen Km Giriniz: ");
            int Km=Convert.ToInt32(Console.ReadLine());
            int yakitHesaplama =car1.YakitHesaplama(Km);
            Console.WriteLine("Belirttiğiniz km'ye göre araç toplam " + yakitHesaplama + "TL yakıt arcamaktadır.");
            Console.ReadLine();
        }
    }
}
