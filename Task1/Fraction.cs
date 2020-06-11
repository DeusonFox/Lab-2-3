using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Fraction
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
            Reduction();
        }
        public static int NOD(int m, int n)
        {
            int temp;
            m = Math.Abs(m);
            n = Math.Abs(n);
            while (n != 0 && m != 0)
            {
                if (m % n > 0)
                {
                    temp = m;
                    m = n;
                    n = temp % n;
                }
                else break;
            }
            if (n != 0 && n != 0) return n;
            else return 0;
        }
        public static bool Equals(Fraction a, Fraction b)
        {
            a.Reduction();
            b.Reduction();
            if (a.Numerator * a.Denominator < 0 && b.Numerator * b.Denominator < 0)
                if (Math.Abs(a.Numerator) == Math.Abs(b.Numerator) && Math.Abs(a.Denominator) == Math.Abs(b.Denominator))
                    return true;
            if (a.Numerator * a.Denominator > 0 && b.Numerator * b.Denominator > 0)
                if ((a.Numerator == b.Numerator) && (a.Denominator == b.Denominator))
                    return true;
            return false;
        }
        public override string ToString()
        {
            return Numerator.ToString() + "/" + Denominator.ToString();
        }
        public Fraction Reduction()
        {
            int nod = NOD(Numerator, Denominator);
            if (nod > 1)
            {
                Numerator /= nod;
                Denominator /= nod;
            }
            return this;

        }
        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            //if (fraction1.Numerator == 0 || fraction2.Numerator == 0 || fraction1.Denominator == 0 || fraction2.Denominator == 0)
            if (fraction1.Numerator == 0 && fraction2.Denominator == 0 || fraction2.Numerator == 0 && fraction1.Denominator == 0 ||
                fraction1.Numerator == 0 && fraction2.Numerator == 0 || fraction1.Denominator == 0 && fraction2.Denominator == 0) return new Fraction(0, 0);

            if (fraction1.Numerator == 0 || fraction1.Denominator == 0) return new Fraction(fraction2.Numerator, fraction2.Denominator);
            if (fraction2.Numerator == 0 || fraction2.Denominator == 0) return new Fraction(fraction1.Numerator, fraction1.Denominator);
            return new Fraction(fraction1.Numerator * fraction2.Denominator + fraction2.Numerator * fraction1.Denominator, fraction1.Denominator * fraction2.Denominator);
        }
        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            if (fraction1.Numerator == 0 && fraction2.Denominator == 0 || fraction2.Numerator == 0 && fraction1.Denominator == 0 ||
                fraction1.Numerator == 0 && fraction2.Numerator == 0 || fraction1.Denominator == 0 && fraction2.Denominator == 0) return new Fraction(0, 0);

            if (fraction1.Numerator == 0 || fraction1.Denominator == 0) return new Fraction( -fraction2.Numerator, fraction2.Denominator);
            if (fraction2.Numerator == 0 || fraction2.Denominator == 0) return new Fraction(fraction1.Numerator, fraction1.Denominator);
            if (fraction1.Numerator == fraction2.Numerator && fraction1.Denominator == fraction2.Denominator) return new Fraction(0, 0);
            else return new Fraction(fraction1.Numerator * fraction2.Denominator - fraction2.Numerator * fraction1.Denominator, fraction1.Denominator * fraction2.Denominator );
        }
        public static Fraction operator *(Fraction fraction1, Fraction fraction2)
        {
            //if (fraction1.Numerator == 0 && fraction2.Denominator == 0 || fraction2.Numerator == 0 && fraction1.Denominator == 0 ||
            //    fraction1.Numerator == 0 && fraction2.Numerator == 0 || fraction1.Denominator == 0 && fraction2.Denominator == 0) return new Fraction(0, 0);

            if (fraction1.Numerator == 0 || fraction1.Denominator == 0 || fraction2.Numerator == 0 || fraction2.Denominator == 0) return new Fraction(0, 0);
            return new Fraction(fraction1.Numerator * fraction2.Numerator, fraction1.Denominator * fraction2.Denominator);
        }
        public static Fraction operator /(Fraction fraction1, Fraction fraction2)
        {
            //if (fraction1.Numerator == 0 && fraction2.Denominator == 0 || fraction2.Numerator == 0 && fraction1.Denominator == 0 ||
            //    fraction1.Numerator == 0 && fraction2.Numerator == 0 || fraction1.Denominator == 0 && fraction2.Denominator == 0) return new Fraction(0, 0);

            if (fraction1.Numerator == 0 || fraction1.Denominator == 0 || fraction2.Numerator == 0 || fraction2.Denominator == 0) return new Fraction(0, 0);
            return new Fraction(fraction1.Numerator * fraction2.Denominator, fraction1.Denominator * fraction2.Numerator);
        }
        public static Fraction Pow(Fraction fraction1, int n)
        {
            if (n == 0) return new Fraction(1, 1);
            if (fraction1.Numerator == 0 || fraction1.Denominator == 0) return new Fraction(0,0);
            else return new Fraction((int)Math.Pow(fraction1.Numerator, n), (int)Math.Pow(fraction1.Denominator, n));
        }
    }
}