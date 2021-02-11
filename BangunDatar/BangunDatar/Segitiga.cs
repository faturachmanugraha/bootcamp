using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class Segitiga : BangunDatar
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

        private double Sisi;

        public double sisi
        {
            get { return Sisi; }
            set { Sisi = value; }
        }


        public override double HitungLuas()
        {
            Hitung = (Alas * Tinggi) / 2;
            return Hitung;
        }

        public override double HitungKeliling()
        {
            Hitung = (Alas + Tinggi + Sisi);
            return Hitung;
        }

    }
}
