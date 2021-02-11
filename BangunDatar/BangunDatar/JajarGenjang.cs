using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class JajarGenjang : BangunDatar
    {
        private double Alas;

        public double alas
        {
            get { return Alas; }
            set { Alas = value; }
        }

        private double Tinggi;

        public double tinggi
        {
            get { return Tinggi; }
            set { Tinggi = value; }
        }

        private double Miring;

        public double miring
        {
            get { return Miring; }
            set { Miring = value; }
        }

        public override double HitungLuas()
        {
            Hitung = (Alas * Tinggi);
            return Hitung;
        }

        public override double HitungKeliling()
        {
            Hitung = 2 * (Alas + Miring);
            return Hitung;
        }

    }
}
