using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com
{
    public class Decimal
    {
        #region Public Methods
        public static Decimal operator +(Decimal dec1, Decimal dec2)
        {
            if (dec1.den == dec2.den)
            {
                return new Decimal { num = dec1.num + dec2.num, den = dec1.den };
            }
            else
            {
                return new Decimal { num = dec1.num * dec2.den + dec2.num * dec1.den, den = dec1.den * dec2.den };
            }
        }

        public static Decimal operator -(Decimal dec1, Decimal dec2)
        {
            if (dec1.den == dec2.den)
            {
                return new Decimal { num = dec1.num - dec2.num, den = dec1.den };
            }
            else
            {
                return new Decimal { num = dec1.num * dec2.den - dec2.num * dec1.den, den = dec1.den * dec2.den };
            }
        }

        public static Decimal operator *(Decimal dec1, Decimal dec2)
        {
                return new Decimal { num = dec1.num * dec2.num, den = dec1.den * dec2.den };
        }

        public static Decimal operator /(Decimal dec1, Decimal dec2)
        {
            return new Decimal { num = dec1.num * dec2.den, den = dec1.den * dec2.num };
        }

        public override string ToString()
        {
            return $"{_num}/{_den}";
        }
        #endregion

        #region Constructors
        public Decimal() { }

        public Decimal(int num, int den)
        {
            _num = num;
            _den = den;
        }
        #endregion

        #region Fields
        private int _num;
        private int _den;
        #endregion

        #region Properties
        public int num
        {
            get { return _num; }
            set { _num = value; }
        }

        public int den
        {
            get { return _den; }
            set { _den = value; }
        }
        #endregion
    }
}
