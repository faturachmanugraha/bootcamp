using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    abstract class BangunDatar
    {
        public double Hitung { get; set; }


        public abstract double HitungLuas();
        public abstract double HitungKeliling();
    }
}
