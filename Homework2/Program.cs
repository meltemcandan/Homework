using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NotEverage();
            //UserSignin();
            //Solger();
            //Price();
        }

        public static void NotEverage()
        {
            double vize, final, sonuc;
            Console.Write("Vize Notunuzu Giriniz: ");
            vize = Convert.ToDouble(Console.ReadLine());
            Console.Write("Final Notunuzu Giriniz: ");
            final = Convert.ToDouble(Console.ReadLine());

            sonuc = vize * 0.4 + final * 0.6;
            if (sonuc > 60)
            {
                Console.WriteLine("Başarılı");
            }
            else
            {
                Console.WriteLine("Başarısız");
            }
            Console.ReadLine();
        }
        public static void UserSignin()
        {
            Console.Write("Kullanıcı Adını Giriniz: ");
            string userName = Console.ReadLine();

            Console.Write("Parolanızı Giriniz: ");
            int password = Convert.ToInt32(Console.ReadLine());


            if (userName.ToLower() == "meltem" && password == 1234)
            {
                Console.WriteLine("Giriş Başarılı");
            }
            else
            {
                Console.WriteLine("Giriş Başarısız");
            }
            Console.ReadLine();
        }
        public static void Solger()
        {
            Console.WriteLine("Cinsiyetinizi Giriniz= ");
            string Gender = Console.ReadLine();
            Console.WriteLine("Yaşınızı Giriniz= ");
            Byte Age = Convert.ToByte(Console.ReadLine());

            if (Gender.ToLower() == "erkek" && Age >= 18)
            {
                Console.WriteLine("Askere Gidebilir");
            }
            else
            {
                Console.WriteLine("Askere Gidemez");
            }
            Console.ReadLine();
        }
        public static void Price()
        {
            Console.Write("Birinci Ürünün Fiyatını Giriniz= ");
            double Urun1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci  Ürünün Fiyatını Giriniz= ");
            double Urun2 = Convert.ToDouble(Console.ReadLine());
            double Toplam = Urun1 + Urun2;
            
            if (Toplam > 200)
            {
                Toplam -= Urun2 * 0.25;
                Console.WriteLine("İndirimli Toplam Fiyat= " + Toplam);
            }
            else
            {
                Console.WriteLine("Normal Toplam Fiyat= " + Toplam);
            }
            Console.ReadLine();
          
            
               
        }

    }

}
