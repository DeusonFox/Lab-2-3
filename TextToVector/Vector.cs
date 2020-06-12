using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToVector
{
    public class Vector
    {
        private List<double> Values { get; }
        public Vector(List<double> values)
        {
            Values = values;
        }
        public Vector(List<double> values, double length)
        {
            Values = values.Select((x) => x / length).ToList();
        }
        public double Length => Math.Sqrt(Values.Select((x) => x * x).Sum());

        public static double operator *(Vector left, Vector right)
            => left.Values.Zip(right.Values, (x, y) => x * y).Sum();

        public static double Cos(Vector left, Vector right)
            => (left.Length > 0 && right.Length > 0) ? (left * right) / left.Length / right.Length : 0;
    }
}
