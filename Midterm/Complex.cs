using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm
{
    public class Complex
    {
        private double rP; // real part
        private double iP; // imaginary part

        public void SetComplex(double r, double i)
        {
            rP = r;
            iP = i;
        }

        public void add(Complex c1)
        {
            rP += c1.rP;
            iP += c1.iP;
        }

        public void addTwo(Complex c1, Complex c2)
        {
            rP = c1.rP + c2.rP;
            iP = c1.iP + c2.iP;
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
            Complex ccopy = new Complex();
            
            ccopy.rP = rP * c1.rP - iP * c1.iP;
            ccopy.iP = rP * c1.iP + iP * c1.rP;
            rP = ccopy.rP;
            iP = ccopy.iP;
        }

        public void div(Complex c1)
        {
            Complex ccopy = new Complex();

            ccopy.rP = (rP * c1.rP + iP * c1.iP) / (c1.rP * c1.rP + c1.iP * c1.iP);
            ccopy.iP = (iP * c1.rP - rP * c1.iP) / (c1.rP * c1.rP + c1.iP * c1.iP);
            rP = ccopy.rP;
            iP = ccopy.iP;

        }

        public void print()
        {
            Console.WriteLine("{0} + {1}i", rP, iP);
        }
    }
}