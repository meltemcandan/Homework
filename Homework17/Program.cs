using System;

namespace Homework17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var me = new MethodExamples("Fatih", "Candan");
            var fullname = me.GetFullName();

            var me2 = new MethodExamples("Fatih", "Candan", "Ondokuz Mayıs");
            var fullname2 = me2.GetFullName();

            var meltem = me2.GetPerson("Meltem", "CAndna", "281843");

            Console.WriteLine("Hello World!");
        }
    }
}
