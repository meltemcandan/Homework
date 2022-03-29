using System;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //***Kullanıcıdan Ad Soyad Bilgisi Alınıp Sisteme Giriş İşlemi***
            bool state = true;

            while (state)
            {
                Console.WriteLine("Adınızı Giriniz: ");
                string name = Console.ReadLine();
                Console.WriteLine("Soyadınızı Giriniz: ");
                string lastName = Console.ReadLine();

                if (name.ToLower() == "feyza" && lastName.ToLower() == "esertepe")
                {
                    Console.WriteLine("Sisteme Giremezsiniz.");
                }
                else
                {
                    Console.WriteLine("Giriş Başarılı Hoşgeldin " + name + " " + lastName);
                    Console.WriteLine("1 Numaralı otel için kişi başı ücretler;\nStandart Oda= 100TL\nLüks Oda= 200TL");
                    Console.WriteLine("2 Numaralı otel için kişi başı ücretler;\nStandart Oda= 300TL\nLüks Oda= 600TL");
                    Console.WriteLine("Lütfen Kalmak istediğiniz oteli seciniz\nOtel 1 mi Otel 2 mi?");
                    byte otel = byte.Parse(Console.ReadLine());
                    Console.WriteLine("Lütfen oda tipini seçiniz (S/L)");
                    string oda = Console.ReadLine();
                    Console.WriteLine("Lütfen kaç gün kalmak istediğinizi belirtiniz");
                    byte day = byte.Parse(Console.ReadLine());

                    if (otel == 1)
                    {
                        switch (oda.ToUpper())
                        {
                            case "S":
                                Console.WriteLine("Standart Oda İçin Toplam Fiyat= " + " " + (day * 100));
                                break;
                            case "L":
                                Console.WriteLine("Lux Oda İçin Toplam Fiyat= " + " " + (day * 200));
                                break;
                        }
                    }

                    else if (otel == 2)
                    {
                        switch (oda.ToUpper())
                        {
                            case "S":
                                Console.WriteLine("Standart Oda İçin Toplam Fiyat= " + " " + (day * 300));
                                break;
                            case "L":
                                Console.WriteLine("Lux Oda İçin Toplam Fiyat= " + " " + (day * 600));
                                break;
                        }
                    }
                }

                Console.WriteLine("Sistem dursun mu? (E/H):");
                string stateStop = Console.ReadLine();
                if (stateStop == "E")
                {
                    state = false;
                }
                Console.ReadLine();
            }
        }
    }
}
