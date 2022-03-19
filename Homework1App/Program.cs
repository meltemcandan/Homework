using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1App
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Kullanıcıdan Değer Alma İşlemleri
            //UserInfo();
            #endregion

            #region Dönüşüm ve Operatör İşlemleri
            //Operator();
            #endregion

            #region Explicit Örneği
            //Explicit();
            #endregion

            #region İmplicit Örneği
            //Implicist();
            #endregion

        }

        public static void UserInfo()
        {
            try
            {
                Console.WriteLine("Adınızı Giriniz: ");
                string name = Console.ReadLine();
                Console.WriteLine("Soyadınızı Giriniz:");
                string lastname = Console.ReadLine();
                Console.WriteLine("Yaşınızı Giriniz: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mesleğinizi Giriniz: ");
                string job = Console.ReadLine();
                Console.WriteLine("Maaşınızı Giriniz(TL): ");
                int salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kullanıcının Adı Soyadı: " + name + " " + lastname);
                Console.WriteLine("Kullanıcının Yaşı: " + age);
                Console.WriteLine("Kullanıcının Mesleği: " + job);
                Console.WriteLine("Kullanıcının Maaşı: " + salary);

            }
            catch (Exception)
            {
                Console.WriteLine("Hatalı Giriş Yaptınız. Lütfen Girdiğiniz Bilgileri Kontrol Ediniz.");
            }

            finally
            {
                Console.WriteLine("Teşekkürler");
            }

            Console.ReadLine();
        }

        public static void Operator()
        {
            try
            {
                Console.WriteLine("Birinci Sayıyı Giriniz: ");
                int sayı1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("İkinci Sayıyı Giriniz: ");
                int sayı2 = Convert.ToInt32(Console.ReadLine());
                int toplamaSonuc = sayı1 + sayı2;
                Console.WriteLine("Toplama Sonucu= " + toplamaSonuc);
                int cıkarmaSonuc = sayı1 - sayı2;
                Console.WriteLine("Çıkarma Sonucu= " + cıkarmaSonuc);
                int carpmaSonuc = sayı1 * sayı2;
                Console.WriteLine("Çarpma Sonucu= " + carpmaSonuc);
                int bolmeSonuc = sayı1 / sayı2;
                Console.WriteLine("Bölme Sonucu= " + bolmeSonuc);
                int kalanSonuc = sayı1 % sayı2;
                Console.WriteLine("Kalan Sonuç= " + kalanSonuc);
                bool kontrol = sayı1 > sayı2;
                Console.WriteLine("Sayı1 Sayı2'den büyük mü? = " + kontrol);
                Console.WriteLine("Sayı1' in İlk Değeri= " + sayı1++);
                Console.WriteLine("Sayı1' in Son Değeri= " + sayı1);
                bool sonuc = toplamaSonuc > 0 && cıkarmaSonuc > 0;
                Console.WriteLine("Toplama  VE Çıkarma Sonuçları 0' dan Büyük Mü?= " + sonuc);

            }

            catch (Exception)
            {
                Console.WriteLine("Lütfen Tam Sayı Giriniz!");
            }

            finally
            {
                Console.WriteLine("Teşekkürler");
            }

            Console.ReadLine();
        }

        public static void Explicit()
        {

            byte x = 50;
            int y = x; ;
            Console.WriteLine(y);
            Console.ReadLine();
        }

        public static void Implicist()
        {
            checked
            {
                try
                {
                    Console.WriteLine("Bir Sayı Giriniz:");
                    byte sayı = Convert.ToByte(Console.ReadLine());
                    int x = sayı;
                    byte y = (byte)x;
                    Console.WriteLine(y);
                }

                catch (Exception)
                {                   
                    Console.WriteLine("0-255 arası bir tam sayı giriniz!");
                }

            }

            Console.ReadLine();
        }
    }
}