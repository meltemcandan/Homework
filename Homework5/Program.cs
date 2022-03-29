using System;

namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--*'larla Dikdörtgen Uygulaması--
            int sayı = 5;
            for (int i = 0; i < sayı; i++)
            {
                if (i == 0 || i == sayı - 1)
                {
                    Console.WriteLine("* * * *");
                }
                else
                {
                    Console.WriteLine("*     *");
                }
            }
            Console.ReadLine();
        }
    }
}
