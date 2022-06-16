using System;

namespace Homework33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Almak istediğiniz ürünleri seçiniz");
            double toplamFiyat = 0;
            var durum = true;
            while (durum)
            {
                Console.WriteLine("1-Domates = 2.5 TL\n2-Patlıcan =7 TL\n3-Salatalık = 4.5 TL\n4-Biber = 11 TL\n5-Patates =5 TL\nAlışverişi tamamlamak için 0' a basınız");
                int secim = Convert.ToInt32(Console.ReadLine());
                
              
                if (secim == 0)
                {
                    durum = false;

                }
                else
                {
                    Console.WriteLine("Almak istediğiniz kg giriniz");
                    double kg = Convert.ToDouble(Console.ReadLine());
                    switch (secim)
                    {
                        case 1:
                            {
                                Domates domates = new Domates(18, 2.5);
                                toplamFiyat = domates.ToplamFiyat(kg);
                            }
                            break;

                        case 2:
                            {
                                Biber biber = new Biber(10, 11);
                                toplamFiyat = biber.ToplamFiyat(kg);

                            }
                            break;
                        case 3:
                            {
                                Patlican patlican = new Patlican(8, 7);
                                toplamFiyat = patlican.ToplamFiyat(kg);
                            }
                            break;
                        case 4:
                            {
                                Salatalik salatalik = new Salatalik(15, 4.5);
                                toplamFiyat = salatalik.ToplamFiyat(kg);
                            }
                            break;
                        case 5:
                            {
                                Patates patates = new Patates(20, 5);
                                toplamFiyat = patates.ToplamFiyat(kg);
                            }
                            break;
                    }
                }
            }



            Console.WriteLine("Ödeyeceğiniz Toplam Fiyat:" + toplamFiyat + "TL");
            Console.ReadLine();
        }
    }
}
