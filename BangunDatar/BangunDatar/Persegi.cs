using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class Persegi : BangunDatar
    {
        private double Sisi;

        public double sisi
        {
            get { return Sisi; }
            set { Sisi = value; }
        }


        public override double HitungLuas()
        {
            Hitung = (Sisi * Sisi);
            return Hitung;
        }

        public override double HitungKeliling()
        {
            Hitung = 4 * Sisi;
            return Hitung;
        }

    }
}
