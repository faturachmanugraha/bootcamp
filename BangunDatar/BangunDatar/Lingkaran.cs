using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class Lingkaran : BangunDatar
    {
        private double JariJari;

        public double jarijari
        {
            get { return JariJari; }
            set { JariJari = value; }
        }

        public override double HitungLuas()
        {
            double pi = 3.14;
            Hitung = pi *  jarijari * jarijari;
            return Hitung;
        }

        public override double HitungKeliling()
        {
            double pi = 3.14;
            Hitung =  pi * 2 * jarijari ;
            return Hitung;
        }


    }
}
