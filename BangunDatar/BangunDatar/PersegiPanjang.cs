using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class PersegiPanjang : BangunDatar
    {
        private double Panjang;

        public double panjang
        {
            get { return Panjang; }
            set { Panjang = value; }
        }

        private double Lebar;

        public double lebar
        {
            get { return Lebar; }
            set { Lebar = value; }
        }

        public override double HitungLuas()
        {
            Hitung = (Panjang * Lebar);
            return Hitung;
        }

        public override double HitungKeliling()
        {
            Hitung = 2 * (Panjang + Lebar);
            return Hitung;
        }


    }
}
