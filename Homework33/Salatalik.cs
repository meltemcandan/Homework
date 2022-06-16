using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework33
{
    public class Salatalik : Urun
    {
        public override double Kdv { get; set; }
        public override double Fiyat { get; set; }

        public Salatalik(double kdv, double fiyat)
        {
            Kdv = kdv;
            Fiyat = fiyat;
        }

        public override double KdvHesaplama(double Kg)
        {
            return base.KdvHesaplama(Kg);
        }
    }
}
