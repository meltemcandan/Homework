using System;

namespace Homework18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci a = new Ogrenci(123, "Meltem", "Candan", 80, 60, 90, "Ondokuz Mayıs Universitesi");

            string ogrenciBilgileri = a.OgrenciBilgileriGoster();

            int ortalama = a.OrtalamaBul();

            string okulİsmi = a.OkulGetir();

            Console.WriteLine("Öğrenci Bilgileri;\n\n" + ogrenciBilgileri);
            Console.WriteLine("Ortalama Not= " + ortalama);
            Console.WriteLine("Ögrenci Okul Adı= " + okulİsmi);
            Console.ReadLine();
        }
    }
}
