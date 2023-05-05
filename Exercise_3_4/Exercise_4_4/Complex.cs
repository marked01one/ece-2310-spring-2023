using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_4_4
{
    public class Complex
    {
        private double rP; // real part
        private double iP; // imaginary part

        public Complex(double r, double i)
        {
            rP = r;
            iP = i;
        }

        public void add(Complex c1)
        {
            rP += c1.rP;
            iP += c1.iP;
        }

        public void diff(Complex c1)
        {
            rP -= c1.rP;
            iP -= c1.iP;
        }

        public void mul(Complex c1)
        {
            // use the formula (a+bj) * (c+dj) = (ac-bd) + (ad+bc)j
            rP = rP * c1.rP - iP * c1.iP;
            iP = rP * c1.iP + iP * c1.rP;
        }

        public void mulfix (Complex c1)
        {
            // use the formula (a+bj) * (c+dj) = (ac-bd) + (ad+bc)j
            Complex ccopy = new Complex(
                r: rP * c1.rP - iP * c1.iP,
                i: rP * c1.iP + iP * c1.rP
            );
            rP = ccopy.rP;
            iP = ccopy.iP;
        }

        public void div(Complex c1)
        {
            Complex ccopy = new Complex(
                r: (rP * c1.rP + iP * c1.iP) / (c1.rP * c1.rP + c1.iP * c1.iP),
                i: (iP * c1.rP - rP * c1.iP) / (c1.rP * c1.rP + c1.iP * c1.iP)
            );
            rP = ccopy.rP;
            iP = ccopy.iP;

        }

        public string returnComplexString()
        {
            if (rP == 0) { return $"{iP}i"; }
            if (iP == 1) { return $"{rP}+i"; }
            if (iP > 1) { return $"{rP}+{iP}i"; }
            return $"{rP}{iP}i";
        }
    }
}