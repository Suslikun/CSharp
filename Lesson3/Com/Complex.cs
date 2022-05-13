using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com
{
    public class Complex
    {
        #region Public Methods
        public static Complex operator +(Complex complex1, Complex complex2)
        {
            return new Complex { Re = complex1.Re + complex2.Re, Im = complex1.Im + complex2.Im };
        }

        public static Complex operator -(Complex complex1, Complex complex2)
        {
            return new Complex { Re = complex1.Re - complex2.Re, Im = complex1.Im - complex2.Im };
        }

        public static Complex operator *(Complex complex1, Complex complex2)
        {
            return new Complex { Re = complex1.Re * complex2.Re - complex1.Im * complex2.Im, Im = complex1.Re * complex2.Im + complex1.Im * complex2.Re};
        }

        public override string ToString()
        {
            return $"{_re}{_im:+0.##;-0.##;+0}*i";
        }
        #endregion

        #region Constructors
        public Complex() { }

        public Complex(double re, double im)
        {
            _re = re;
            _im = im;
        }
        #endregion

        #region Fields
        private double _re;
        private double _im;
        #endregion

        #region Properties
        public double Re
        {
            get { return _re; }
            set { _re = value; }
        }

        public double Im
        {
            get { return _im; }
            set { _im = value; }
        }
        #endregion
    }
}
