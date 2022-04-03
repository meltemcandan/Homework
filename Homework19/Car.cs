using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework19
{
    public class Car
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Rengi { get; set; }
        public int Yili { get; set; }
        public int KmBasiYakit { get; set; }

        public Car(string _Marka, string _Model, string _Rengi, int _Yili, int _KmBasiYakit)
        {
            Marka = _Marka;
            Model = _Model; 
            Rengi = _Rengi; 
            Yili = _Yili;   
            KmBasiYakit = _KmBasiYakit;
                    
        }
        public string CarData()
        {
           return "Araba Markası: " + Marka + "\nAraba Modeli: " + Model + "\nAraba Rengi: " + Rengi + "\nAraç Yapım Yılı: " + Yili + "\nAraç Km Başı Harcadığı Yakıt: " + KmBasiYakit;
        }

        public int YakitHesaplama(int gidecegiKm)
        {
            return (gidecegiKm * KmBasiYakit);
           
        }
    }

}
