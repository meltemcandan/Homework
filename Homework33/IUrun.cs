using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework33
{
    public interface IUrun
    {
        double Kdv { get; set; }
        double Fiyat { get; set; }
        double KdvHesaplama(double kg);
        double ToplamFiyat(double kg);
    }
}
