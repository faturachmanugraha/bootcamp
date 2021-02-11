using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class LayangLayang : BangunDatar
    {
        private double Diagonal1;

        public double diagonal1
        {
            get { return Diagonal1; }
            set { Diagonal1 = value; }
        }

        private double Diagonal2;

        public double diagonal2
        {
            get { return Diagonal2; }
            set { Diagonal2 = value; }
        }

        private double Sisi1;

        public double sisi1
        {
            get { return Sisi1; }
            set { Sisi1 = value; }
        }

        private double Sisi2;

        public double sisi2
        {
            get { return Sisi2; }
            set { Sisi2 = value; }
        }

        public override double HitungLuas()
        {

            Hitung = Diagonal1 * Diagonal2 / 2;
            return Hitung;
        }

        public override double HitungKeliling()
        {

            Hitung = 2 * (Sisi1+Sisi2);
            return Hitung;
        }


    }
}
