using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Polynomial
    {
        double[] coefficients;

        public Polynomial(IList<double> collection)
        {
            if (collection.Count > 0)
                this.coefficients = collection.ToArray();
            else
                this.coefficients = new double[1];
        }

        private Polynomial(int degree)
        {
            this.coefficients = new double[degree];
        }

        public int Degree
        {
            get
            {
                int degree = this.coefficients.Length - 1;
                while (degree > 0 && this.coefficients[degree] == 0)
                    degree--;
                return degree;
            }
        }

        public double GetValue(double variable)
        {
            double value = 0;
            for (int i = 0; i <= this.Degree; i++)
                value += this.coefficients[i] * Math.Pow(variable, i);
            return value;
        }

        public static Polynomial operator +(Polynomial a, Polynomial b)
        {
            Polynomial result = new Polynomial(Math.Max(a.Degree, b.Degree) + 1);
            for (int i = 0; i < result.coefficients.Length; i++)
                result.coefficients[i] =
                    (a.Degree + 1 > i ? a.coefficients[i] : 0) +
                    (b.Degree + 1 > i ? b.coefficients[i] : 0);
            return result;
        }

        public static Polynomial operator -(Polynomial a, Polynomial b)
        {
            Polynomial result = new Polynomial(Math.Max(a.Degree, b.Degree) + 1);
            for (int i = 0; i < result.coefficients.Length; i++)
                result.coefficients[i] =
                    (a.Degree + 1 > i ? a.coefficients[i] : 0) -
                    (b.Degree + 1 > i ? b.coefficients[i] : 0);
            return result;
        }

        public static Polynomial operator *(Polynomial a, Polynomial b)
        {
            Polynomial result = new Polynomial(a.Degree + b.Degree + 1);
            for (int i = 0; i < a.Degree + 1; i++)
                for (int j = 0; j < b.Degree + 1; j++)
                    result.coefficients[i + j] += a.coefficients[i] * b.coefficients[j];
            return result;
        }

        public static bool operator ==(Polynomial a, Polynomial b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Polynomial a, Polynomial b)
        {
            return !a.Equals(b);
        }

        public static bool operator >(Polynomial a, Polynomial b)
        {
            if (a.Degree < b.Degree)
                return false;
            else if (a.Degree > b.Degree)
                return true;
            for (int i = a.Degree; i >= 0; i--)
                if (a.coefficients[i] > b.coefficients[i])
                    return true;
                else if (a.coefficients[i] < b.coefficients[i])
                    return false;
            return false;
        }

        public static bool operator <(Polynomial a, Polynomial b)
        {
            return a <= b && a != b;
        }

        public static bool operator <=(Polynomial a, Polynomial b)
        {
            return !(a > b);
        }

        public static bool operator >=(Polynomial a, Polynomial b)
        {
            return a == b || a > b;
        }

        public double this[int index]
        {
            get
            {
                if (index >= 0 && index <= this.Degree) return this.coefficients[index];
                else throw new IndexOutOfRangeException();
            }
        }

        public override string ToString()
        {
            string result = "";
            for (int i = this.Degree; i >= 0; i--)
            {
                if (Math.Abs(this.coefficients[i]) < double.Epsilon)
                    continue;
                if (i != this.Degree && this.coefficients[i] > 0)
                    result += "+";
                if (this.coefficients[i] == -1 && i != 0)
                    result += "-";
                else if (this.coefficients[i] != 1 || i == 0)
                    result += this.coefficients[i].ToString();
                if (i != 0)
                    result += "x";
                if (i != 0 && i != 1)
                    result += $"^{i}";
            }
            if (result == "")
                result = "0";
            return result;
        }

        public override bool Equals(object obj)
        {
            if (this.Degree != (obj as Polynomial).Degree)
                return false;
            for (int i = 0; i < this.Degree + 1; i++)
                if (this.coefficients[i] != (obj as Polynomial).coefficients[i])
                    return false;
            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = this.Degree.GetHashCode();
            for (int i = 0; i < this.Degree + 1; i++)
                hashCode += this.coefficients[i].GetHashCode();
            return hashCode;
        }
    }
}

