using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Haftanın günlerini bir dizi içine atayarak ekrana yazdırma örneği

            string[] days = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }
            Console.ReadLine();
        }
    }
}
