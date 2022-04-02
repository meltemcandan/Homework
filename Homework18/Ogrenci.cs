using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework18
{
    public class Ogrenci
    {
        private int OgrenciNo { get; set; }
        private string İsim { get; set; }
        private string Soyisim { get; set; }
        private int Vize1 { get; set; }
        private int Vize2 { get; set; }
        private int Final { get; set; }
        private string Okulİsmi { get; set; }

        public Ogrenci(int _OgrenciNo, string _İsim, string _Soyisim, int _Vize1, int _Vize2, int _Final, string _Okulİsmi)
        {
            OgrenciNo = _OgrenciNo;
            İsim = _İsim;
            Soyisim = _Soyisim;
            Vize1 = _Vize1;
            Vize2 = _Vize2;
            Final = _Final;
            Okulİsmi = _Okulİsmi;
        }

        public string OgrenciBilgileriGoster()
        {
            return "Öğrenci No= " + OgrenciNo + "\nÖğrenci İsmi= " + İsim + "\nÖğrenci Soyismi= " + Soyisim + "\nBirinci Vize Notu= " + Vize1 + "\nİkinci Vize Notu= " + Vize2 + "\nFinal Notu= " + Final + "\nOkul İsmi= " + Okulİsmi;
        }
        public int OrtalamaBul()
        {
            return (((Vize1 * 20) / 100) + ((Vize2 * 20) / 100) + ((Final * 60) / 100));

        }
        public string OkulGetir()
        {
            return Okulİsmi;

        }
    }
}
