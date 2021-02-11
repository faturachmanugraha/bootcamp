using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class Trapesium : BangunDatar
    {
        private double SisiAtas;

        public double sisiAtas
        {
            get { return SisiAtas; }
            set { SisiAtas = value; }
        }

        private double SisiBawah;

        public double sisiBawah
        {
            get { return SisiBawah; }
            set { SisiBawah = value; }
        }
        private double SisiSamping1;

        public double sisiSamping1
        {
            get { return SisiSamping1; }
            set { SisiSamping1 = value; }
        }

        private double SisiSamping2;

        public double sisiSamping2
        {
            get { return SisiSamping2; }
            set { SisiSamping2 = value; }
        }



        private double Tinggi;

        public double tinggi
        {
            get { return Tinggi; }
            set { Tinggi = value; }
        }

        public override double HitungLuas()
        {
           
            Hitung = (SisiAtas + SisiBawah)*Tinggi/2;
            return Hitung;
        }

        public override double HitungKeliling()
        {
            
            Hitung = SisiAtas + SisiBawah + SisiSamping1 + SisiSamping2;
            return Hitung;
        }

    }
}
