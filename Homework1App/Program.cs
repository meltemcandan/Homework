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

            Console.WriteLine("Adınızı Giriniz: ");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz:");
            string lastname= Console.ReadLine();    
            Console.WriteLine("Yaşınızı Giriniz: ");
            int age= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mesleğinizi Giriniz: ");
            string job= Console.ReadLine(); 
            Console.WriteLine("Maaşınızı Giriniz(TL): ");
            int salary= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kullanıcının Adı Soyadı: " + name + " " + lastname);
            Console.WriteLine("Kullanıcının Yaşı: " + age);
            Console.WriteLine("Kullanıcının Mesleği: " + job);
            Console.WriteLine("Kullanıcının Maaşı: " + salary);
            Console.ReadLine();
        }
    }
}