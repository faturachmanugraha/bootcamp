using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class BelahKetupat : BangunDatar
    {
        private double Sisi;

        public double sisi
        {
            get { return Sisi; }
            set { Sisi = value; }
        }

        private double Diagonal;

        public double diagonal
        {
            get { return Diagonal; }
            set { Diagonal = value; }
        }

        public override double HitungLuas()
        {
            Hitung = (Diagonal * Diagonal)/2;
            return Hitung;
        }

        public override double HitungKeliling()
        {
            Hitung = 4 * (Sisi);
            return Hitung;
        }

    }
}
