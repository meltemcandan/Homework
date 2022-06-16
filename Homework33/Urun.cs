using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework33
{
    public abstract class Urun
    {
        public virtual double Kdv { get; set; } 
        public virtual double Fiyat { get; set; } 

        public virtual double KdvHesaplama(double kg)
        {
            return Fiyat * kg * Kdv / 100;
        }

        public double ToplamFiyat(double kg)
        {
            return Fiyat + KdvHesaplama(kg);
        }
    }
}
