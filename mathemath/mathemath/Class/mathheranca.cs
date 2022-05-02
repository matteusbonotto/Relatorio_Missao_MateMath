using System;
using System.Collections.Generic;
using System.Text;

namespace mathemath
{
    public class mathheranca : math
    {
        private double r;
        private double n1 { set; get; }

        public mathheranca(double n1, double n2) : base(n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        public double Soma(double n1, double n2)
        {
            r = n1 + n2;
            return r;
        }

    }
}

