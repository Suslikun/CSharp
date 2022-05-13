using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexAll
{
    class Complex
    {
        #region Public Methods
        //Перегрузка оператора +, сложение комплексных чисел
        public static Complex operator +(Complex complex1, Complex complex2)
        {
            return new Complex { Re = complex1.Re + complex2.Re, Im = complex1.Im + complex2.Im };
        }

        public override string ToString()
        {
            return $"{_re} {_im}i";
        }
        #endregion

        #region Constructors
        public Complex() { }

        public Complex(double re, double im)
        {
            _re = re;
            this._im = im;
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
