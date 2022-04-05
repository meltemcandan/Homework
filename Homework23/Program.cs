using System;

namespace Homework23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir otoparka park eden taksinin 1 saati 5TL, minibüsün 1 saati 6TL, ticari aracın 1 saati 6.5TL dir. Taksi 1 saatten sonraki her saat başı için %20 daha fazla, minibüs 1 saatten sonraki her saat başı için toplamda %21.5 ve ticari araç 1 saatten sonraki her saat başı için toplamda %25 daha fazla ödeme yapmaktadır. Buna göre  girilen araba tipi ve kalınan saat bilgisi girildikten sonra ekrana ödenecek otopark ücretini hesaplayan programın kodlarını yazınız.

            double odenecekTutar;
            int kalinanSure=0;
            int aracTipi = 0;
            
            Console.WriteLine("Taksi: 1");
            Console.WriteLine("Minibüs: 2");
            Console.WriteLine("Ticari Araç: 3");
            Console.WriteLine("Lütfen araç tipini seçiniz: ");
            aracTipi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen kalınan süreyi giriniz: ");
            kalinanSure = Convert.ToInt32(Console.ReadLine());

            if (kalinanSure>1)
            {
                for (int i = 1; i <= kalinanSure; i++)
                {
                    if (i==1)
                    {
                        if (aracTipi==1)
                        {
                            Console.WriteLine(odenecekTutar = (i*5));
                        }
                        else if (aracTipi==2)
                        {
                            Console.WriteLine(odenecekTutar = (i * 6));
                        }
                        else if (aracTipi==3)
                        {
                            Console.WriteLine(odenecekTutar = (i * 6.5));
                        }
                    }
                    else
                    {
                        kalinanSure-=1;
                        
                        if (aracTipi == 1)
                        {
                            odenecekTutar = odenecekTutar + Convert.ToDouble(kalinanSure * 1.20 * 5);
                            Console.WriteLine();
                        }
                        else if (aracTipi == 2)
                        {
                            Console.WriteLine(odenecekTutar += kalinanSure * 6 * 1.215 );
                        }
                        else if (aracTipi == 3)
                        {
                            Console.WriteLine(odenecekTutar += kalinanSure* 6.5 * 1.25);
                        }
                    }
                }        
            }
            else
            {
                if (aracTipi == 1)
                {
                    Console.WriteLine(odenecekTutar =  5);
                }
                else if (aracTipi == 2)
                {
                    Console.WriteLine(odenecekTutar = 6);
                }
                else if (aracTipi == 3)
                {
                    Console.WriteLine(odenecekTutar = 6.5);
                }
            }

            Console.WriteLine("Ödenecek Tutar: " + odenecekTutar);
            Console.ReadLine();



        }
    }
}
